namespace Ch_9_Fuzzy_Logic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMFSTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartMFSChargeRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMFSVoltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBatteryVsTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableControls = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTrickleVoltageRate = new System.Windows.Forms.TextBox();
            this.tbTrickleTempRate = new System.Windows.Forms.TextBox();
            this.tbFastVoltageRate = new System.Windows.Forms.TextBox();
            this.tbFastTempRate = new System.Windows.Forms.TextBox();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbVoltage = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lblRates = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSimulationTIme = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbVoltageDrawShift = new System.Windows.Forms.TextBox();
            this.tbVoltageDrawAmplitude = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVoltageDrawFequency = new System.Windows.Forms.TextBox();
            this.rbtnFuzzySet = new System.Windows.Forms.RadioButton();
            this.rbtnMamdani = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSTemperature)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSChargeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSVoltage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBatteryVsTime)).BeginInit();
            this.tableControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMFSTemperature
            // 
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea5.Name = "ChartArea1";
            this.chartMFSTemperature.ChartAreas.Add(chartArea5);
            this.chartMFSTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartMFSTemperature.Legends.Add(legend5);
            this.chartMFSTemperature.Location = new System.Drawing.Point(152, 2);
            this.chartMFSTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.chartMFSTemperature.Name = "chartMFSTemperature";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartMFSTemperature.Series.Add(series5);
            this.chartMFSTemperature.Size = new System.Drawing.Size(277, 168);
            this.chartMFSTemperature.TabIndex = 0;
            this.chartMFSTemperature.TabStop = false;
            this.chartMFSTemperature.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Membership Functions: Temperature";
            this.chartMFSTemperature.Titles.Add(title5);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.chartMFSChargeRate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartMFSTemperature, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartMFSVoltage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartBatteryVsTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableControls, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(854, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chartMFSChargeRate
            // 
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea6.Name = "ChartArea1";
            this.chartMFSChargeRate.ChartAreas.Add(chartArea6);
            this.chartMFSChargeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartMFSChargeRate.Legends.Add(legend6);
            this.chartMFSChargeRate.Location = new System.Drawing.Point(152, 346);
            this.chartMFSChargeRate.Margin = new System.Windows.Forms.Padding(2);
            this.chartMFSChargeRate.Name = "chartMFSChargeRate";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMFSChargeRate.Series.Add(series6);
            this.chartMFSChargeRate.Size = new System.Drawing.Size(277, 168);
            this.chartMFSChargeRate.TabIndex = 4;
            this.chartMFSChargeRate.TabStop = false;
            this.chartMFSChargeRate.Text = "chart1";
            title6.Name = "Title1";
            title6.Text = "Membership Functions: Charge Rate";
            this.chartMFSChargeRate.Titles.Add(title6);
            // 
            // chartMFSVoltage
            // 
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea7.Name = "ChartArea1";
            this.chartMFSVoltage.ChartAreas.Add(chartArea7);
            this.chartMFSVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Name = "Legend1";
            this.chartMFSVoltage.Legends.Add(legend7);
            this.chartMFSVoltage.Location = new System.Drawing.Point(152, 174);
            this.chartMFSVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.chartMFSVoltage.Name = "chartMFSVoltage";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartMFSVoltage.Series.Add(series7);
            this.chartMFSVoltage.Size = new System.Drawing.Size(277, 168);
            this.chartMFSVoltage.TabIndex = 1;
            this.chartMFSVoltage.TabStop = false;
            this.chartMFSVoltage.Text = "chart1";
            title7.Name = "Title1";
            title7.Text = "Membership Functions: Voltage";
            this.chartMFSVoltage.Titles.Add(title7);
            // 
            // chartBatteryVsTime
            // 
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea8.Name = "ChartArea1";
            this.chartBatteryVsTime.ChartAreas.Add(chartArea8);
            this.chartBatteryVsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Name = "Legend1";
            this.chartBatteryVsTime.Legends.Add(legend8);
            this.chartBatteryVsTime.Location = new System.Drawing.Point(433, 2);
            this.chartBatteryVsTime.Margin = new System.Windows.Forms.Padding(2);
            this.chartBatteryVsTime.Name = "chartBatteryVsTime";
            this.tableLayoutPanel1.SetRowSpan(this.chartBatteryVsTime, 3);
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartBatteryVsTime.Series.Add(series8);
            this.chartBatteryVsTime.Size = new System.Drawing.Size(419, 512);
            this.chartBatteryVsTime.TabIndex = 2;
            this.chartBatteryVsTime.TabStop = false;
            this.chartBatteryVsTime.Text = "chart1";
            title8.Name = "Title1";
            title8.Text = "Battery Vs Time";
            this.chartBatteryVsTime.Titles.Add(title8);
            // 
            // tableControls
            // 
            this.tableControls.AutoSize = true;
            this.tableControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableControls.ColumnCount = 2;
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableControls.Controls.Add(this.label1, 0, 5);
            this.tableControls.Controls.Add(this.label2, 0, 6);
            this.tableControls.Controls.Add(this.label3, 0, 8);
            this.tableControls.Controls.Add(this.label4, 0, 7);
            this.tableControls.Controls.Add(this.tbTrickleVoltageRate, 1, 5);
            this.tableControls.Controls.Add(this.tbTrickleTempRate, 1, 6);
            this.tableControls.Controls.Add(this.tbFastVoltageRate, 1, 7);
            this.tableControls.Controls.Add(this.tbFastTempRate, 1, 8);
            this.tableControls.Controls.Add(this.btnSimulate, 0, 15);
            this.tableControls.Controls.Add(this.label5, 0, 0);
            this.tableControls.Controls.Add(this.label6, 0, 1);
            this.tableControls.Controls.Add(this.label7, 0, 2);
            this.tableControls.Controls.Add(this.tbVoltage, 1, 1);
            this.tableControls.Controls.Add(this.tbTemperature, 1, 2);
            this.tableControls.Controls.Add(this.lblRates, 0, 4);
            this.tableControls.Controls.Add(this.label8, 0, 9);
            this.tableControls.Controls.Add(this.tbSimulationTIme, 1, 9);
            this.tableControls.Controls.Add(this.label9, 0, 12);
            this.tableControls.Controls.Add(this.label10, 0, 11);
            this.tableControls.Controls.Add(this.label11, 0, 13);
            this.tableControls.Controls.Add(this.tbVoltageDrawShift, 1, 12);
            this.tableControls.Controls.Add(this.tbVoltageDrawAmplitude, 1, 13);
            this.tableControls.Controls.Add(this.label12, 0, 14);
            this.tableControls.Controls.Add(this.tbVoltageDrawFequency, 1, 14);
            this.tableControls.Controls.Add(this.rbtnFuzzySet, 0, 16);
            this.tableControls.Controls.Add(this.rbtnMamdani, 0, 17);
            this.tableControls.Location = new System.Drawing.Point(2, 2);
            this.tableControls.Margin = new System.Windows.Forms.Padding(2);
            this.tableControls.Name = "tableControls";
            this.tableControls.RowCount = 18;
            this.tableLayoutPanel1.SetRowSpan(this.tableControls, 3);
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableControls.Size = new System.Drawing.Size(146, 383);
            this.tableControls.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TrickleVoltageRate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TrickleTempRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FastTempRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FastVoltageRate";
            // 
            // tbTrickleVoltageRate
            // 
            this.tbTrickleVoltageRate.Location = new System.Drawing.Point(113, 94);
            this.tbTrickleVoltageRate.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrickleVoltageRate.Name = "tbTrickleVoltageRate";
            this.tbTrickleVoltageRate.Size = new System.Drawing.Size(31, 20);
            this.tbTrickleVoltageRate.TabIndex = 2;
            this.tbTrickleVoltageRate.Text = "1.01";
            this.tbTrickleVoltageRate.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbTrickleTempRate
            // 
            this.tbTrickleTempRate.Location = new System.Drawing.Point(113, 118);
            this.tbTrickleTempRate.Margin = new System.Windows.Forms.Padding(2);
            this.tbTrickleTempRate.Name = "tbTrickleTempRate";
            this.tbTrickleTempRate.Size = new System.Drawing.Size(31, 20);
            this.tbTrickleTempRate.TabIndex = 3;
            this.tbTrickleTempRate.Text = "0.95";
            this.tbTrickleTempRate.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbFastVoltageRate
            // 
            this.tbFastVoltageRate.Location = new System.Drawing.Point(113, 142);
            this.tbFastVoltageRate.Margin = new System.Windows.Forms.Padding(2);
            this.tbFastVoltageRate.Name = "tbFastVoltageRate";
            this.tbFastVoltageRate.Size = new System.Drawing.Size(31, 20);
            this.tbFastVoltageRate.TabIndex = 5;
            this.tbFastVoltageRate.Text = "3";
            this.tbFastVoltageRate.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbFastTempRate
            // 
            this.tbFastTempRate.Location = new System.Drawing.Point(113, 166);
            this.tbFastTempRate.Margin = new System.Windows.Forms.Padding(2);
            this.tbFastTempRate.Name = "tbFastTempRate";
            this.tbFastTempRate.Size = new System.Drawing.Size(31, 20);
            this.tbFastTempRate.TabIndex = 6;
            this.tbFastTempRate.Text = "1.05";
            this.tbFastTempRate.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSimulate.Location = new System.Drawing.Point(2, 313);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(107, 22);
            this.btnSimulate.TabIndex = 11;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Battery";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Voltage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Temperature";
            // 
            // tbVoltage
            // 
            this.tbVoltage.Location = new System.Drawing.Point(113, 19);
            this.tbVoltage.Margin = new System.Windows.Forms.Padding(2);
            this.tbVoltage.Name = "tbVoltage";
            this.tbVoltage.Size = new System.Drawing.Size(31, 20);
            this.tbVoltage.TabIndex = 0;
            this.tbVoltage.Text = "30";
            this.tbVoltage.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbTemperature
            // 
            this.tbTemperature.Location = new System.Drawing.Point(113, 43);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(31, 20);
            this.tbTemperature.TabIndex = 1;
            this.tbTemperature.Text = "13";
            this.tbTemperature.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRates.Location = new System.Drawing.Point(2, 75);
            this.lblRates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(60, 17);
            this.lblRates.TabIndex = 14;
            this.lblRates.Text = "Charge";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 188);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sim. Time";
            // 
            // tbSimulationTIme
            // 
            this.tbSimulationTIme.Location = new System.Drawing.Point(113, 190);
            this.tbSimulationTIme.Margin = new System.Windows.Forms.Padding(2);
            this.tbSimulationTIme.Name = "tbSimulationTIme";
            this.tbSimulationTIme.Size = new System.Drawing.Size(31, 20);
            this.tbSimulationTIme.TabIndex = 7;
            this.tbSimulationTIme.Text = "900";
            this.tbSimulationTIme.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 239);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Shift";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Discharge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 263);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Amplitude";
            // 
            // tbVoltageDrawShift
            // 
            this.tbVoltageDrawShift.Location = new System.Drawing.Point(113, 241);
            this.tbVoltageDrawShift.Margin = new System.Windows.Forms.Padding(2);
            this.tbVoltageDrawShift.Name = "tbVoltageDrawShift";
            this.tbVoltageDrawShift.Size = new System.Drawing.Size(31, 20);
            this.tbVoltageDrawShift.TabIndex = 8;
            this.tbVoltageDrawShift.Text = "1";
            this.tbVoltageDrawShift.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tbVoltageDrawAmplitude
            // 
            this.tbVoltageDrawAmplitude.Location = new System.Drawing.Point(113, 265);
            this.tbVoltageDrawAmplitude.Margin = new System.Windows.Forms.Padding(2);
            this.tbVoltageDrawAmplitude.Name = "tbVoltageDrawAmplitude";
            this.tbVoltageDrawAmplitude.Size = new System.Drawing.Size(31, 20);
            this.tbVoltageDrawAmplitude.TabIndex = 9;
            this.tbVoltageDrawAmplitude.Text = "1";
            this.tbVoltageDrawAmplitude.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Frequency";
            // 
            // tbVoltageDrawFequency
            // 
            this.tbVoltageDrawFequency.Location = new System.Drawing.Point(113, 289);
            this.tbVoltageDrawFequency.Margin = new System.Windows.Forms.Padding(2);
            this.tbVoltageDrawFequency.Name = "tbVoltageDrawFequency";
            this.tbVoltageDrawFequency.Size = new System.Drawing.Size(31, 20);
            this.tbVoltageDrawFequency.TabIndex = 10;
            this.tbVoltageDrawFequency.Text = "5";
            this.tbVoltageDrawFequency.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // rbtnFuzzySet
            // 
            this.rbtnFuzzySet.AutoSize = true;
            this.rbtnFuzzySet.Location = new System.Drawing.Point(3, 340);
            this.rbtnFuzzySet.Name = "rbtnFuzzySet";
            this.rbtnFuzzySet.Size = new System.Drawing.Size(68, 17);
            this.rbtnFuzzySet.TabIndex = 12;
            this.rbtnFuzzySet.Text = "FuzzySet";
            this.rbtnFuzzySet.UseVisualStyleBackColor = true;
            this.rbtnFuzzySet.CheckedChanged += new System.EventHandler(this.rbtnFuzzyMethod_CheckedChanged);
            // 
            // rbtnMamdani
            // 
            this.rbtnMamdani.AutoSize = true;
            this.rbtnMamdani.Checked = true;
            this.rbtnMamdani.Location = new System.Drawing.Point(3, 363);
            this.rbtnMamdani.Name = "rbtnMamdani";
            this.rbtnMamdani.Size = new System.Drawing.Size(68, 17);
            this.rbtnMamdani.TabIndex = 13;
            this.rbtnMamdani.TabStop = true;
            this.rbtnMamdani.Text = "Mamdani";
            this.rbtnMamdani.UseVisualStyleBackColor = true;
            this.rbtnMamdani.CheckedChanged += new System.EventHandler(this.rbtnFuzzyMethod_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ch 9 - Fuzzy Logic - Battery Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSTemperature)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSChargeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMFSVoltage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBatteryVsTime)).EndInit();
            this.tableControls.ResumeLayout(false);
            this.tableControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMFSTemperature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMFSVoltage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBatteryVsTime;
        private System.Windows.Forms.TableLayoutPanel tableControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTrickleVoltageRate;
        private System.Windows.Forms.TextBox tbTrickleTempRate;
        private System.Windows.Forms.TextBox tbFastVoltageRate;
        private System.Windows.Forms.TextBox tbFastTempRate;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbVoltage;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSimulationTIme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbVoltageDrawShift;
        private System.Windows.Forms.TextBox tbVoltageDrawAmplitude;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVoltageDrawFequency;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMFSChargeRate;
        private System.Windows.Forms.RadioButton rbtnFuzzySet;
        private System.Windows.Forms.RadioButton rbtnMamdani;
    }
}

