using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class ReservationManagement
    {
        public void HowLongIsStay(Dog dog)
        {
            bool firstDayParseResult, lastDayParseResult;
            DateTime firstDay, lastDay;

            do
            {
                Console.WriteLine("Please enter the day of arrival of your dog: ");
                Console.WriteLine("(for example: 31-01-2021)");

                string startDay = Console.ReadLine();
                firstDayParseResult = DateTime.TryParse(startDay, out firstDay);

                if (!firstDayParseResult)
                {
                    Console.WriteLine("Value invalid");
                }
                
            } while (!firstDayParseResult);


            do
            {
                Console.WriteLine("Please enter the day of departure of your dog");

                string dayEnd = Console.ReadLine();
                lastDayParseResult = DateTime.TryParse(dayEnd, out lastDay);

                if (!lastDayParseResult)
                {
                    Console.WriteLine("Value invalid");
                }

            } while (!lastDayParseResult);

            int lengthOfStay = DayNumberOfStay(firstDay, lastDay);
            Console.WriteLine($"Your dog will stay with us for {lengthOfStay} days");
            decimal price = Price(lengthOfStay, dog.Weight);
            Console.WriteLine($"The cost of a {dog.Name} stay is {price} PLN");
        }
        private int DayNumberOfStay(DateTime firstDay, DateTime lastDay)
        {
            TimeSpan result = lastDay - firstDay;
            string TotalDays = result.TotalDays.ToString();
            int totalDays;
            Int32.TryParse(TotalDays, out totalDays);
            return totalDays;
        }
        private decimal Price(int totalDays, int weight)
        {
            decimal price;


            if (weight <= 10)
            {
                if (totalDays > 3)
                {
                    price = totalDays * 50;
                }
                else
                {
                    price = totalDays * 60;
                }
            }
            else
            {
                if (totalDays > 3)
                {
                    price = totalDays * 60;
                }
                else
                {
                    price = totalDays * 70;
                }
            }
            return price;
        }
    }
}
