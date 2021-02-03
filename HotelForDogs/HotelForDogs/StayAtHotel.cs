using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotel
    {

        public int Id { get; set; }
        public Client Client { get; set; }
        public decimal Price { get; set; }
        public Dog Dog { get; set; }

        

        List<StayAtHotel> listOfStays = new List<StayAtHotel>();

        public List<StayAtHotel> AddNewStay(int id, Client client, Dog dog)
        {

            StayAtHotel stay = new StayAtHotel();
            listOfStays.Add(stay);
            return listOfStays;

        }
    }
}
