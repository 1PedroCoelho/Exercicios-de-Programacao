static class ConversorTemperatura
{
    public static double CelsiusParaFahrenheit(double c)
    {
      return (c*9/5)+32;  
    }
    public static double FahrenheitParaCelsius(double f)
    {
        return (f-32)*5/9;
    } 
}
class Program
{
    public static void Main()
    {
        Console.WriteLine($"Temperatura em Celsius: {ConversorTemperatura.CelsiusParaFahrenheit(0)}");
        Console.WriteLine($"Temperatura em Fahrenheit: {ConversorTemperatura.FahrenheitParaCelsius(32)}");
    }
}