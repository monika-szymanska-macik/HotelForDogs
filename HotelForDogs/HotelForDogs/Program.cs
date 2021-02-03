using System;

namespace HotelForDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I invite you to visit my Hotel for Dogs! You can spend your holidays not worrying about your dog.");
            Console.WriteLine("Please enter the day of arrival of your dog: ");
            Console.WriteLine("(for example: 31-01-2021)");

            string startDay = Console.ReadLine();
            DateTime firstDay;
            DateTime.TryParse(startDay, out firstDay);

            Console.WriteLine("Please enter the day of departure of your dog");

            string dayEnd = Console.ReadLine();
            DateTime lastDay;
            DateTime.TryParse(dayEnd, out lastDay);


            Console.WriteLine("How much your dog weight?");

            string dogWeightString = Console.ReadLine();
            int dogWeight;
            Int32.TryParse(dogWeightString, out dogWeight);

            static decimal Price(int firstDay, int lastDay, int weight) //cena zalezna od ilosci dni i wagi psa ale gdzie w kodzie to powinno byc ? non so..
            {
                decimal price = 0.0M;
                DayNumberOfStay(firstDay, lastDay);
                return price;
            }
            static int DayNumberOfStay(DateTime firstDay, DateTime lastDay)
            {
                TimeSpan result = lastDay - firstDay;
                string TotalDays = result.TotalDays.ToString();
                int totalDays;
                Int32.TryParse(TotalDays, out totalDays);
                Console.WriteLine(totalDays);
                return totalDays;
            }

        }
    }
}
