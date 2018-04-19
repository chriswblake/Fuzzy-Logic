using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ch_9_Fuzzy_Logic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Battery theBattery = new Battery(30, 12);

            //Show membership functinos for temperature
            chartMFSTemperature.Series.Clear();
            foreach (Series s in theBattery.MembershipFunctionsTemperature)
                chartMFSTemperature.Series.Add(s);
            chartMFSTemperature.ChartAreas[0].AxisX.Minimum = 0;
            chartMFSTemperature.ChartAreas[0].AxisX.Interval = 10;

            //Show membership functinos for voltage
            chartMFSVoltage.Series.Clear();
            foreach (Series s in theBattery.MembershipFunctionsVoltage)
                chartMFSVoltage.Series.Add(s);
            chartMFSVoltage.ChartAreas[0].AxisX.Minimum = 0;
            chartMFSVoltage.ChartAreas[0].AxisX.Interval = 10;

            //Show membership functinos for voltage
            chartMFSChargeRate.Series.Clear();
            foreach (Series s in theBattery.MembershipFunctionsChargeRate)
                chartMFSChargeRate.Series.Add(s);
            chartMFSChargeRate.ChartAreas[0].AxisX.Minimum = 0;
            chartMFSChargeRate.ChartAreas[0].AxisX.Interval = 1;
            chartMFSChargeRate.ChartAreas[0].AxisX.MajorGrid.Interval = 0.1;

            //Change axis of Battery vs Time
            chartBatteryVsTime.ChartAreas[0].AxisX.Minimum = 0;
            chartBatteryVsTime.ChartAreas[0].AxisY.Minimum = 0;
            chartBatteryVsTime.ChartAreas[0].AxisY.Maximum = 60;
        }

        //Methods
        public Series ListToLineSeries(string name, List<double> data)
        {
            Series theSeries = new Series(name) { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };

            for (int t = 0; t < data.Count; t++)
            {
                theSeries.Points.AddXY(t+1, data[t]);
            }

            return theSeries;
        }
        public void simulateSet(Battery theBattery, SimulationParameters simParam, out List<double> statsVoltage, out List<double> statsTemperature, out List<double> statsChargeMode, out List<double> statsVoltageDraw)
        {
            //Stats
            statsVoltage = new List<double>();
            statsTemperature = new List<double>();
            statsChargeMode = new List<double>();
            statsVoltageDraw = new List<double>();

            //Simulate for a duration of time
            int timeEnd = simParam.simulationTime;
            for (int time = 1; time <= timeEnd; time++)
            {
                double rateVoltage = 1.0;
                double rateTemperature = 1.0;

                //Adjust rate by charge mode
                if (theBattery.ChargeMode == Battery.ChargeModeOption.Trickle)
                { 
                    rateVoltage = simParam.trickleVoltageRate;
                    rateTemperature = simParam.trickleTemperatureRate;
                }
                else if (theBattery.ChargeMode == Battery.ChargeModeOption.Fast)
                {
                    rateVoltage = simParam.fastVoltageRate;
                    rateTemperature = simParam.fastTemperatureRate;
                }

                //Get current battery levels
                double newVoltage = theBattery.Voltage;
                double newTemperature = theBattery.Temperature;

                //Check for dead battery
                if (newVoltage == 0)
                    newVoltage = 1;

                //Generate new battery levels
                newVoltage += rateVoltage;
                newTemperature *= rateTemperature;

                //Simulate voltage being drawn
                double voltageDraw = simParam.voltageDrawShift + simParam.voltageDrawAmplitude* (1 + Math.Sin(time / simParam.voltageDrawFrequency));
                statsVoltageDraw.Add(voltageDraw);
                newVoltage -= voltageDraw;

                //Update battery
                theBattery.Voltage = newVoltage;
                theBattery.Temperature = newTemperature;

                //Save value into statistics;
                statsVoltage.Add(theBattery.Voltage);
                statsTemperature.Add(theBattery.Temperature);
                statsChargeMode.Add(10*theBattery.ChargeModeInt);
            }
        }
        public void simulateMamdani(Battery theBattery, SimulationParameters simParam, out List<double> statsVoltage, out List<double> statsTemperature, out List<double> statsChargeMode, out List<double> statsVoltageDraw)
        {
            //Stats
            statsVoltage = new List<double>();
            statsTemperature = new List<double>();
            statsChargeMode = new List<double>();
            statsVoltageDraw = new List<double>();

            //Factor Ranges
            double voltageFactorLow = simParam.trickleVoltageRate;
            double voltageFactorDelta = simParam.fastVoltageRate - simParam.trickleVoltageRate;

            double tempFactorLow = simParam.trickleTemperatureRate;
            double tempFactorDelta = simParam.fastTemperatureRate - simParam.trickleTemperatureRate;         


            //Simulate for a duration of time
            int timeEnd = simParam.simulationTime;
            for (int time = 1; time <= timeEnd; time++)
            {
                //Adjust rate by charge mode
                double mamdaniFactor = theBattery.chargeRateMamdani();
                double rateVoltage = voltageFactorLow + voltageFactorDelta * mamdaniFactor;
                double rateTemperature = tempFactorLow + tempFactorDelta * mamdaniFactor;

                //Get current battery levels
                double newVoltage = theBattery.Voltage;
                double newTemperature = theBattery.Temperature;

                //Check for dead battery
                if (newVoltage == 0)
                    newVoltage = 1;

                //Generate new battery levels
                newVoltage += rateVoltage;
                newTemperature *= rateTemperature;

                //Simulate voltage being drawn
                double voltageDraw = simParam.voltageDrawShift + simParam.voltageDrawAmplitude * (1 + Math.Sin(time / simParam.voltageDrawFrequency));
                statsVoltageDraw.Add(voltageDraw);
                newVoltage -= voltageDraw;

                //Update battery
                theBattery.Voltage = newVoltage;
                theBattery.Temperature = newTemperature;

                //Save value into statistics;
                statsVoltage.Add(theBattery.Voltage);
                statsTemperature.Add(theBattery.Temperature);
                statsChargeMode.Add(1+10*mamdaniFactor);
            }
        }

        //Classes
        public struct SimulationParameters
        {
            public int simulationTime;

            public double trickleVoltageRate;
            public double trickleTemperatureRate;

            public double fastVoltageRate;
            public double fastTemperatureRate;

            public double voltageDrawShift;
            public double voltageDrawAmplitude;
            public double voltageDrawFrequency;
        }


        //Controls
        private void btnSimulate_Click(object sender, EventArgs e)
        {
            //Get inputs
            SimulationParameters simParam = new SimulationParameters();
            double initVoltage = 0;
            double initTemperature = 0;
            try
            {
                initVoltage = Convert.ToDouble(tbVoltage.Text);
                initTemperature = Convert.ToDouble(tbTemperature.Text);

                simParam.simulationTime = Convert.ToInt32(tbSimulationTIme.Text);

                simParam.trickleVoltageRate = Convert.ToDouble(tbTrickleVoltageRate.Text);
                simParam.trickleTemperatureRate = Convert.ToDouble(tbTrickleTempRate.Text);

                simParam.fastVoltageRate = Convert.ToDouble(tbFastVoltageRate.Text);
                simParam.fastTemperatureRate = Convert.ToDouble(tbFastTempRate.Text);

                simParam.voltageDrawShift = Convert.ToDouble(tbVoltageDrawShift.Text);
                simParam.voltageDrawAmplitude = Convert.ToDouble(tbVoltageDrawAmplitude.Text);
                simParam.voltageDrawFrequency = Convert.ToDouble(tbVoltageDrawFequency.Text);
            }
            catch { return; }

            //Create a battery
            Battery theBattery = new Battery(initVoltage, initTemperature);

            //Simulate the battery for X time
            List<double> statsVoltage = new List<double>();
            List<double> statsTemperature = new List<double>();
            List<double> statsChargeMode = new List<double>();
            List<double> statsVoltageDraw = new List<double>();
            if (rbtnFuzzySet.Checked)
                simulateSet(theBattery, simParam, out statsVoltage, out statsTemperature, out statsChargeMode, out statsVoltageDraw);
            else if (rbtnMamdani.Checked)
                simulateMamdani(theBattery, simParam, out statsVoltage, out statsTemperature, out statsChargeMode, out statsVoltageDraw);
            else
                return; //should never occur

            //Show Battery vs Time
            chartBatteryVsTime.Series.Clear();
            chartBatteryVsTime.Series.Add(ListToLineSeries("Voltage", statsVoltage));
            chartBatteryVsTime.Series.Add(ListToLineSeries("Temperature", statsTemperature));
            chartBatteryVsTime.Series.Add(ListToLineSeries("Charge Mode (10=Trickle, 20=Fast)", statsChargeMode));
            chartBatteryVsTime.Series.Add(ListToLineSeries("Voltage Draw", statsVoltageDraw));
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            btnSimulate_Click(null, null);
        }
        private void rbtnFuzzyMethod_CheckedChanged(object sender, EventArgs e)
        {
            btnSimulate_Click(null, null);
        }
    }

    //Classes
    public class Battery
    {
        double voltage; const double maxVoltage = 35;
        double temperature; const double maxTemperature = 60;

        //Constructor
        public Battery(double voltage, double temperature)
        {
            Voltage = voltage;
            Temperature = temperature;
        }

        //Membership functions - Voltage
        public double voltageCentroidMamdani(double voltage)
        {
            double moment = 0;
            double area = 0;
            const double dv = 0.1;

            //Clip Points
            double clipLow = voltageLow(voltage);
            double clipMedium = voltageMedium(voltage);
            double clipHigh = voltageHigh(voltage);

            //Calculate area and moment
            for (double v=0; v<maxVoltage; v+=dv)
            {
                double height =
                    Fuzzy.and //maximum between values
                    (
                        Fuzzy.and //Maximum between values
                        (
                            Fuzzy.or(voltageLow(v), clipLow), //Pick minimum between values.
                            Fuzzy.or(voltageMedium(v), clipMedium) //Pick minimum between values.
                        ),
                        Fuzzy.or(voltageHigh(v), clipHigh) //Pick minimum between values.
                    );

                //height = Fuzzy.and(height, voltage); //cuts off peeks
                moment += v * height * dv;
                area += height * dv; 
            }

            //Calculate centroid of area
            double centroid = moment / area;

            //Calculate response
            double response =
                    Fuzzy.and //maximum between values
                    (
                        Fuzzy.and //Maximum between values
                        (
                            Fuzzy.or(voltageLow(centroid), clipLow), //Pick minimum between values.
                            Fuzzy.or(voltageMedium(centroid), clipMedium) //Pick minimum between values.
                        ),
                        Fuzzy.or(voltageHigh(centroid), clipHigh) //Pick minimum between values.
                    );

            return response;
        }
        private double voltageLow (double voltage)
        {
            const double low = 5.0;
            const double low_plat = 5.0;
            const double high_plat = 5.0;
            const double high = 10.0;

            if (voltage < low) return 1.0;
            if (voltage > high) return 0.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);

        }
        private double voltageMedium(double voltage)
        {
            const double low = 5.0;
            const double low_plat = 10.0;
            const double high_plat = 20.0;
            const double high = 25.0;

            if (voltage < low) return 0.0;
            if (voltage > high) return 0.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);
        }
        private double voltageHigh(double voltage)
        {
            const double low = 20.0;
            const double low_plat = 25.0;
            const double high_plat = 25.0;
            const double high = 25.0;

            if (voltage < low) return 0.0;
            if (voltage > high) return 1.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);
        }

        //Membership functions - Temperature
        private double temperatureCold(double temp)
        {
            const double low = 15.0;
            const double low_plat = 15.0;
            const double high_plat = 15.0;
            const double high = 25.0;

            if (temp < low) return 1.0;
            if (temp > high) return 0.0;

            return Fuzzy.profileTrapezoid(temp, low, low_plat, high_plat, high);
        }
        private double temperatureWarm(double temp)
        {
            const double low = 15.0;
            const double low_plat = 25.0;
            const double high_plat = 35.0;
            const double high = 45.0;

            if (temp < low) return 0.0;
            if (temp > high) return 0.0;

            return Fuzzy.profileTrapezoid(temp, low, low_plat, high_plat, high);
        }
        private double temperatureHot(double temp)
        {
            const double low = 35.0;
            const double low_plat = 45.0;
            const double high_plat = 45.0;
            const double high = 45.0;

            if (temp < low) return 0.0;
            if (temp > high) return 1.0;

            return Fuzzy.profileTrapezoid(temp, low, low_plat, high_plat, high);
        }

        //Membership functions - Charge Rate
        public double chargeRateCentroid(double clipZero, double clipSlow, double clipFast)
        {
            double moment = 0;
            double area = 0;
            const double dv = 0.001;

            //Calculate area and moment
            for (double v = 0; v < 1; v += dv)
            {
                double height =
                    Fuzzy.or //maximum between values
                    (
                        Fuzzy.or //Maximum between values
                        (
                            Fuzzy.and(chargeZero(v), clipZero), //Pick minimum between values.
                            Fuzzy.and(chargeSlow(v), clipSlow) //Pick minimum between values.
                        ),
                        Fuzzy.and(chargeFast(v), clipFast) //Pick minimum between values.
                    );

                //height = Fuzzy.and(height, voltage); //cuts off peeks
                moment += v * height * dv;
                area += height * dv;
            }

            //Calculate centroid of area
            double centroid = moment / area;

            return centroid;
        }
        private double chargeZero(double voltage)
        {
            const double low = 0.0;
            const double low_plat = 0.0;
            const double high_plat = 0.0;
            const double high = 0.4;

            if (voltage < low) return 1.0;
            if (voltage > high) return 0.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);
        }     
        private double chargeSlow(double voltage)
        {
            const double low = 0.0;
            const double low_plat = 0.4;
            const double high_plat = 0.8;
            const double high = 0.9;

            if (voltage < low) return 0.0;
            if (voltage > high) return 0.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);
        }
        private double chargeFast(double voltage)
        {
            const double low = 0.8;
            const double low_plat = 0.9;
            const double high_plat = 1.0;
            const double high = 1.0;

            if (voltage < low) return 0.0;
            if (voltage > high) return 1.0;

            return Fuzzy.profileTrapezoid(voltage, low, low_plat, high_plat, high);
        }

        //Result Equaton
        public double chargeRateMamdani()
        {
            //1.) voltage high or temperature high => zero
            double r1Zero = Fuzzy.or(
                                voltageHigh(voltage),
                                temperatureHot(temperature));

            //2.) voltage low and temperature cold => fast
            double r2Fast = Fuzzy.and(
                                voltageLow(voltage),
                                temperatureCold(temperature));

            //3.) voltage low and temperature warm => slow
            double r3Slow = Fuzzy.and(
                                voltageLow(voltage),
                                temperatureWarm(temperature));

            //4.) voltage medium and temperature cold => slow
            double r4Slow = Fuzzy.and(
                                voltageMedium(voltage),
                                temperatureCold(temperature));

            //5.) voltage medium and temperature warm => slow
            double r5Slow = Fuzzy.and(
                                voltageMedium(voltage),
                                temperatureWarm(temperature));

            //Combine rule responses
            double clipZero = r1Zero;
            double clipSlow = Fuzzy.or(Fuzzy.or(r3Slow, r4Slow), r5Slow); //select maximum
            double clipFast = r2Fast;

            //Create response from centroid
            double response = chargeRateCentroid(clipZero, clipSlow, clipFast);
            

            //Return result
            return response;
        }

        //Properties
        public int ChargeModeInt
        {
            get
            {
                if (ChargeMode == ChargeModeOption.Trickle)
                    return 1;
                if (ChargeMode == ChargeModeOption.Fast)
                    return 2;
                else
                    return 0; //Unknown (some error)
            }
        }
        public ChargeModeOption ChargeMode
        {
            get
            {
                if (normalize(voltageHigh(Voltage)))
                {
                    return ChargeModeOption.Trickle;
                }
                else if (normalize(temperatureHot(Temperature)))
                {
                    return ChargeModeOption.Trickle;
                }
                else if (normalize(
                                Fuzzy.and(
                                        Fuzzy.not(voltageHigh(Voltage)),
                                        Fuzzy.not(temperatureHot(Temperature))
                                        )
                                  )
                        )
                {
                    return ChargeModeOption.Fast;
                }
                else
                {
                    return ChargeModeOption.Trickle;
                }
            }
        }
        public ChargeModeOption ChargeModeMamdami
        {
            get
            {
                if (normalize(voltageHigh(Voltage)))
                {
                    return ChargeModeOption.Trickle;
                }
                else if (normalize(temperatureHot(Temperature)))
                {
                    return ChargeModeOption.Trickle;
                }
                else if (normalize(
                                Fuzzy.and(
                                        Fuzzy.not(voltageHigh(Voltage)),
                                        Fuzzy.not(temperatureHot(Temperature))
                                        )
                                  )
                        )
                {
                    return ChargeModeOption.Fast;
                }
                else
                {
                    return ChargeModeOption.Trickle;
                }
            }
        }
        public double Voltage
        {
            get { return this.voltage;  }
            set
            {
                if (value <= 0)
                    this.voltage = 0;
                else if (value >= maxVoltage)
                    this.voltage = maxVoltage;
                else
                    this.voltage = value;
            }
        }
        public double Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value <= 0)
                    this.temperature = 0;
                else if (value >= maxTemperature)
                    this.temperature = maxTemperature;
                else
                    this.temperature = value;
            }
        }

        public List<Series> MembershipFunctionsVoltage
        {
            get
            { 
                //Configuration
                const double start = 0;
                const double end = 35;
                const double step = 1;

                //Series
                Series low = new Series("Low") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series medium = new Series("Medium") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series high = new Series("High") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };

                //Add data to series
                for (double x=start; x<=end; x+=step)
                {
                    low.Points.AddXY(x, voltageLow(x));
                    medium.Points.AddXY(x, voltageMedium(x));
                    high.Points.AddXY(x, voltageHigh(x));
                }

                //Provide results
                return new List<Series>() { low, medium, high};
            }
        }
        public List<Series> MembershipFunctionsTemperature
        {
            get
            {
                //Configuration
                const double start = 0;
                const double end = 60;
                const double step = 1;

                //Series
                Series cold = new Series("Cold") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series warm = new Series("Warm") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series hot = new Series("Hot") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };

                //Add data to series
                for (double x = start; x <= end; x += step)
                {
                    cold.Points.AddXY(x, temperatureCold(x));
                    warm.Points.AddXY(x, temperatureWarm(x));
                    hot.Points.AddXY(x, temperatureHot(x));
                }

                //Provide results
                return new List<Series>() { cold, warm, hot };
            }
        }
        public List<Series> MembershipFunctionsChargeRate
        {
            get
            {
                //Configuration
                const double start = 0;
                const double end = 1;
                const double step = 0.05;

                //Series
                Series zero = new Series("Zero") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series slow = new Series("Slow") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };
                Series fast = new Series("Fast") { ChartType = SeriesChartType.Line, MarkerStyle = MarkerStyle.Circle };

                //Add data to series
                for (double x = start; x <= end; x += step)
                {
                    zero.Points.AddXY(x, chargeZero(x));
                    slow.Points.AddXY(x, chargeSlow(x));
                    fast.Points.AddXY(x, chargeFast(x));
                }

                //Provide results
                return new List<Series>() { zero, slow, fast };
            }
        }
        public bool normalize(double value)
        {
            double rValue = Math.Round(value, 0);
            if (rValue == 1)
                return true;
            else
                return false;
        }

        //Enums
        public enum ChargeModeOption
        {
            Trickle,
            Fast
        }
    }
    public static class Fuzzy
    {
        //Logic
        public static double and(double a, double b)
        {
            //Min
            if (a < b)
                return a;
            else
                return b;
        }
        public static double or(double a, double b)
        {
            //Max
            if (a > b)
                return a;
            else
                return b;
        }
        public static double not(double a)
        {
            return (1.0-a);
        }

        //Membership function shapes
        public static double profileTriangle(double value, double low, double high)
        {
            double peak;

            //Normalize to 1
            value += (-low);
            if ((low < 0) && (high < 0))
                high = -(high - low);
            else if ((low < 0) && (high > 0)) 
                high += -low;
            else if ((low > 0) && (high > 0))
                high -= low;
            peak = (high / 2.0);
            low = 0.0;

            //Generate result
            if (value < peak)
                return (value / peak);
            else if (value > peak)
                return ((high - value) / peak);
            else
                return 1.0;
        }
        public static double profileTrapezoid(double value, double low, double low_plat, double high_plat, double high)
        {
            double upslope;
            double downslope;

            value += (-low);

            if (low < 0.0)
            {
                low_plat += -low; high_plat += -low;
                high += -low; low = 0;
            }
            else
            {
                low_plat -= low; high_plat -= low;
                high -= low; low = 0;
            }

            upslope = (1.0 / (low_plat - low));
            downslope = (1.0 / (high - high_plat));

            if (value < low) return 0.0;
            else if (value > high) return 0.0;
            else if ((value >= low_plat) && (value <= high_plat)) return 1.0;
            else if (value < low_plat) return ((value - low) * upslope);
            else if (value > high_plat) return ((high - value) * downslope);

            return 0.0;
        } 
    }
}
