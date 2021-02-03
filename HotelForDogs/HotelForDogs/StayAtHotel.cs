using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotel
    {
        public StayAtHotel(int id, Client client, decimal price, Dog dog)
        {
            Id = id;
            Client = client;
            Price = price;
            Dog = dog;
        }

        public int Id { get; set; }
        public Client Client { get; set; }
        public decimal Price { get; set; }
        public Dog Dog { get; set; }
        public int TimeOfStayAtHotel { get; set; }

        public string DayNumberOfStay(DateTime firstDay, DateTime lastDay)
        {
            TimeSpan result = lastDay - firstDay;
            string TotalDays = result.TotalDays.ToString();
            Console.WriteLine(TotalDays);
            return TotalDays;
        }
    }
}
