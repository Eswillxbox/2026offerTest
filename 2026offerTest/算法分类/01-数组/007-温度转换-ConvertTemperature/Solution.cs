namespace _2026offerTest.习题集;

public class Temperature
{
    public double[] ConvertTemperature(double celsius)
    {
        double[] ans = new double[2] { celsius + 273.15, celsius * 1.80 + 32.00 };
        return ans;
    }
}