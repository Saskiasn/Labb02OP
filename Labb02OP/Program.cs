namespace Labb02OP;

class Program
{
    static void Main(string[] args)
    {
        //Vi deklarera 2 variabler som är av datatypen double som kan hantera decimaltal.
        double temperature;

        double windSpeed;


        while (true)
        {

        Console.WriteLine("-------------------------------------------------");

            //Skriv ut meddelande till användare för val
        Console.WriteLine("\nHej och vällkommen du kommer nu få två val välj med siffran 1 eller 2\n");
        Console.WriteLine("1. Beräkna windchill-faktor\n");
        Console.WriteLine("2. Avsluta programmet\n");

        //Läser in användares knappval
        char inputChar = Console.ReadKey().KeyChar;

        switch (inputChar)
        {

            case '1':

                //Vi skriver ut ett meddelande till användare genom metoden .Write av classen Console
                Console.Write("\n\nAnge utetemperatur i Celsius: ");

                //Läser in användarens med hjälp av svar och lagrar den som en string i identifierare temperatureString
                string temperatureString = Console.ReadLine();

                //Konverterar temperatureString till en double som lagras i identifierare temperature
                temperature = Convert.ToDouble(temperatureString);


                //Samma princip som rad 13-19
                Console.Write("Ange vindhastigheten i km/h: ");

                string windSpeedString = Console.ReadLine();
                windSpeed = Convert.ToDouble(windSpeedString);


                //Skapar en ny variabel av data typen double som innehåller en uträkning. Använder mig av metoden .Pow för att räkna ut uphöjt till 0.16.
                double windChillWCT = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(windSpeed, 0.16) + 0.3965 * temperature * Math.Pow(windSpeed, 0.16);

                string coldnessString;
                if (windChillWCT > -25) {
                    coldnessString = "Kallt";
                } else if (windChillWCT >= -35) {
                    coldnessString = "Mycket kallt";
                } else if (windChillWCT >= -60) {
                    coldnessString = "Risk för frostskada";
                } else {   //default allt är kallare än -60
                    coldnessString = "Stor risk för frostskada";
                }

                //Skriver ut resultatet till användare

                Console.WriteLine($"\nDet kommer bli {coldnessString}");
                Console.WriteLine($"\nWindchill-faktorn vid en temperatur på {temperature}°C och en vindhastighet på {windSpeed} km/h är: {windChillWCT}\n");
                break;

            case '2':

                Console.WriteLine("\n\nProgrammet avslutas.");
                Environment.Exit(0);
                break;


            // Trycker användaren på något annat än 1-2 får man felmeddelande
            default:
                Console.WriteLine("Ogiltigt val.\n");
                Console.WriteLine("Programmet avslutas.");
                Environment.Exit(0);
                break;


        }

        }













    }
}

