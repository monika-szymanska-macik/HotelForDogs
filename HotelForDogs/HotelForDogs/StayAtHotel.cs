using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotel //Reservation
    {
        private ClientService _clientService;
        private DogService _dogService;
        public StayAtHotel()
        {
            _clientService = new ClientService();
            _dogService = new DogService();
        }

        public int Id { get; set; }
        public Client Client { get; set; }


        private List<Dog> _dogs;


        List<StayAtHotel> listOfStays = new List<StayAtHotel>();

        //StayAtHotelService w repository serviski z client i dog , serive hotel = korzysta z serw dog i client (c# sql lite) singleton 
        
        

        
        


    }
    }
