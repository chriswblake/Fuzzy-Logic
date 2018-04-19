		#define MAX(a,b)  ((a>b) ? a : b)
		#define MIN(a,b)  ((a<b) ? a : b)


		fuzzyType fuzzyAnd(fuzzyType a, fuzzyType b)
{
	return MAX(a, b);
}
		fuzzyType fuzzyOr(fuzzyType a, fuzzyType b)
{
	return MIN(a, b);
}
		fuzzyType fuzzyNot(fuzzyType a)
{
	return(1.0 - a);
}

		fuzzyType spikeProfile(float value, float lo, float high)
{
	float peak;

	value += (-lo);

	if ((lo < 0) && (high < 0))
	{
		high = -(high - lo);
	}
	else if ((lo < 0) && (high > 0))
	{
		high += -lo;
	}
	else if ((lo > 0) && (high > 0))
	{
		high -= lo;
	}

	peak = (high / 2.0);
	lo = 0.0;

	if (value < peak) {
		return(value / peak);
	}
	else if (value > peak) {
		return((high - value) / peak);
	}

	return 1.0;
}
		fuzzyType plateauProfile(float value, float lo, float lo_plat, float hi_plat, float hi)
{
	float upslope;
	float downslope;

	value += (-lo);

	if (lo < 0.0) {
		lo_plat += -lo;  hi_plat += -lo;
		hi += -lo;  lo = 0;
	}
	else {
		lo_plat -= lo;  hi_plat -= lo;
		hi -= lo;  lo = 0;
	}

	upslope = (1.0 / (lo_plat - lo));
	downslope = (1.0 / (hi - hi_plat));

	if (value < lo) return 0.0;
	else if (value > hi) return 0.0;
	else if ((value >= lo_plat) && (value <= hi_plat)) return 1.0;
	else if (value < lo_plat) return ((value - lo) * upslope);
	else if (value > hi_plat) return ((hi - value) * downslope);

	return 0.0;
}

		fuzzyType m_voltage_low(float voltage)
{
	const float lo = 5.0;
	const float lo_plat = 5.0;
	const float hi_plat = 5.0;
	const float hi = 10.0;

	if (voltage < lo) return 1.0;
	if (voltage > hi) return 0.0;

	return plateauProfile(voltage, lo, lo_plat, hi_plat, hi);
}
		fuzzyType m_voltage_medium(float voltage)
{
	const float lo = 5.0;
	const float lo_plat = 10.0;
	const float hi_plat = 20.0;
	const float hi = 25.0;

	if (voltage < lo) return 0.0;
	if (voltage > hi) return 0.0;

	return plateauProfile(voltage, lo, lo_plat, hi_plat, hi);
}
		fuzzyType m_voltage_high(float voltage)
{
	const float lo = 25.0;
	const float lo_plat = 30.0;
	const float hi_plat = 30.0;
	const float hi = 30.0;

	if (voltage < lo) return 0.0;
	if (voltage > hi) return 1.0;

	return plateauProfile(voltage, lo, lo_plat, hi_plat, hi);
}

		fuzzyType m_temp_cold(float temp)
{
	const float lo = 15.0;
	const float lo_plat = 15.0;
	const float hi_plat = 15.0;
	const float hi = 25.0;

	if (temp < lo) return 1.0;
	if (temp > hi) return 0.0;

	return plateauProfile(temp, lo, lo_plat, hi_plat, hi);
}
		fuzzyType m_voltage_low(float voltage)
{
	const float lo = 5.0;
	const float lo_plat = 5.0;
	const float hi_plat = 5.0;
	const float hi = 10.0;

	if (voltage < lo) return 1.0;
	if (voltage > hi) return 0.0;

	return plateauProfile(voltage, lo, lo_plat, hi_plat, hi);
}
		fuzzyType m_voltage_medium(float voltage)
{
	const float lo = 5.0;
	const float lo_plat = 10.0;
	const float hi_plat = 20.0;
	const float hi = 25.0;

	if (voltage < lo) return 0.0;
	if (voltage > hi) return 0.0;

	return plateauProfile(voltage, lo, lo_plat, hi_plat, hi);
}

		void chargeControl()
{
	static unsigned int i = 0;

	extern float voltage, temperature;

	if ((i++ % 10) == 0)
	{
		if (normalize(m_voltage_high(voltage)))
		{
			chargeMode = TRICKLE_CHARGE;
		}
		else if (normalize(m_temp_hot(temperature)))
		{
			chargeMode = TRICKLE_CHARGE;
		}
		else if (normalize(
						fuzzyAnd(
								fuzzyNot(m_voltage_high(voltage)),
								fuzzyNot(m_temp_hot(temperature))
								)
						  )
			    )
		{
			chargeMode = FAST_CHARGE;
		}
	}
}
int main()
{
	int i;

	extern int simulate(void);
	extern void chargeControl(float *);

	extern float voltage;
	extern float temperature;
	extern int chargeMode;

	for (i = 0; i < 3000; i++)
	{
		simulate();
		chargeControl();
		printf("%d, %f, %f, %d\n",
			i,
			voltage,
			temperature,
			chargeMode
		);

	}
	return 0;
}
