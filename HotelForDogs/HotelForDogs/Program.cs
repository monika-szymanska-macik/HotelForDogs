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
            Dog dog = new SmallDog(1, "Fiona", "Sznaucer", 8);

            Client clien = new Client(1, "Monika", "Monika", "55");

            StayAtHotel stay = new StayAtHotel(1, clien, 50, dog);

            stay.DayNumberOfStay(firstDay, lastDay);

        }
    }
}
