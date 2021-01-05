using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The Observer Pattern: defines a one-to-many
             * dependency between objects so that when one
             * object changes state, all of its dependents are
             * notified and updated automatically.
             *
             *Design principle: Strive for loosely coupled designs between objects that interact.
             *
             */

            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
