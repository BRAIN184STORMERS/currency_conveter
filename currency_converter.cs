
using System;

namespace Currency_Converter
{
    class Program
    {
        private static double start_currency;

        static void Main(string[] args)
        {
            //exchange rates for multiple currencies
            double UsdtoEuroRates = 0.95;
            double UsdtoKshsRates = 147.55;
            double KshstoEuroRates = 0.0064;
            double KshstoUsdRates = 0.0068;
            double EurotoUsdRates = 1.06;
            double EurotoKshsRates = 156.10;
            double DirtoEuroRates = 0.26;
            double DirtoKshsRates = 40.97;
            double DirtoUsdRates = 0.27;
            double KshstoDirRates = 0.024;
            double UsdtoDirRates = 3.67;
            double EurotoDirRates = 3.88;

            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine("** Welcome to the currency converter! **");
            System.Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            System.Console.WriteLine(" ");
            //indicates the currencies that can be converted.
            System.Console.WriteLine("These are the currencies you can convert");
            System.Console.WriteLine("Euros(EUR), Kenyan Shillings(KSHS), United States Dollars(USD), Dirhams(DIR).");

            do
            {
                //get the user input on the ammount to be converted and give an error if the data type is wrong.
                System.Console.Write("Enter the amount you want to convert : ");
                if (double.TryParse(Console.ReadLine(), out start_currency)) { }
                else
                {
                    System.Console.WriteLine("INVALID INPUT OF THE AMOUNT!");
                }

                System.Console.WriteLine("Here are the currencies conversion choices.");
                System.Console.WriteLine("");
                System.Console.WriteLine("1. : Euros to Kenyan Shillings");
                System.Console.WriteLine("2 : Euros to United states Dollars");
                System.Console.WriteLine("3 : Kenyan Shillings to Euros");
                System.Console.WriteLine("4 : Kenyan Shilling to United States Dollars");
                System.Console.WriteLine("5 : United  States Dollars to Kenyan shilling");
                System.Console.WriteLine("6 : Dirham to United states Dollars");
                System.Console.WriteLine("7 : Dirhams to Kenyan Shillings");
                System.Console.WriteLine("8 : Dirhams to Euros");
                System.Console.WriteLine("9 : Euros to Dirhams");
                System.Console.WriteLine("10 : Kenyan Shilling to Dirhams");
                System.Console.WriteLine("11 : United States Dollars to Dirhams");
                System.Console.WriteLine("");
                System.Console.WriteLine("Enter your choice: ");
                string initials = Console.ReadLine();

                double final_currency = 0;
                switch (initials)
                {
                    case "1":
                        final_currency = start_currency * EurotoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} KSHS");
                        break;
                    case "2":
                        final_currency = start_currency * EurotoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} USD");
                        break;
                    case "3":
                        final_currency = start_currency * KshstoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} EUR");
                        break;
                    case "4":
                        final_currency = start_currency * KshstoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} USD");
                        break;
                    case "USDTOEUR":
                        final_currency = start_currency * UsdtoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} EUR");
                        break;
                    case "5":
                        final_currency = start_currency * UsdtoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} KSHS");
                        break;
                    case "6":
                        final_currency = start_currency * DirtoUsdRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} USD");
                        break;
                    case "7":
                        final_currency = start_currency * DirtoKshsRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} KSHS");
                        break;
                    case "8":
                        final_currency = start_currency * DirtoEuroRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} EUR");
                        break;
                    case "9":
                        final_currency = start_currency * EurotoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} DIR");
                        break;
                    case "10":
                        final_currency = start_currency * KshstoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} DIR");
                        break;
                    case "11":
                        final_currency = start_currency * UsdtoDirRates;
                        System.Console.WriteLine($"Converted amount = {final_currency:F2} DIR");
                        break;
                    default:
                        System.Console.WriteLine("INVALID OPTION!");
                        break;
                }
                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            }
            while (Console.ReadLine().ToUpper() == "Y");

            System.Console.WriteLine("Thank you and Bye!  (^_^)");
        }
    }
}
