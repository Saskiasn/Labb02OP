namespace Labb02OP;

class Program
{
    static void Main(string[] args)
    {
        //Vi deklarera 2 variabler som är av datatypen double som kan hantera decimaltal.
        double temperature;

        double windSpeed;

        //Vi skriver ut ett meddelande till användare genom metoden .Write av classen Console
        Console.Write("Ange utetemperatur i Celsius: ");

        //Läser in användarens med hjälp av svar och lagrar den som en string i identifierare temperatureString
        string temperatureString = Console.ReadLine();

        //Konverterar temperatureString till en double som lagras i identifierare temperature
        temperature = Convert.ToDouble(temperatureString);


        //Samma princip som rad 13-19
        Console.Write("Ange vindhastigheten i km/h: ");

        string windSpeedString = Console.ReadLine();
        windSpeed = Convert.ToDouble(windSpeedString);


        //Skapar en ny variabel av data typen double som innehåller en uträkning. Använder mig av metoden .Pow för att räkna ut uphöjt till 0.16.
        double windChillWCT = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow (windSpeed, 0.16);


        //Skriver ut resultatet till användare
        Console.WriteLine($"Windchill-faktorn vid en temperatur på {temperature}°C och en vindhastighet på {windSpeed} km/h är: {windChillWCT}");
    }
}

