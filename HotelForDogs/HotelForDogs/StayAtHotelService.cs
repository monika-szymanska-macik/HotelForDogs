using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotelService
    {
        private ReservationManagement _reservationManagement;
        private DogService _dogService;
        private ClientService _clientService;
        private List<StayAtHotel> _listOfStays;
        public StayAtHotelService()
        {
            _reservationManagement = new ReservationManagement();
            _listOfStays = new List<StayAtHotel>();
            _dogService = new DogService();
            _clientService = new ClientService();

        }
        public void AddNewStay(int clientId)
        {
            StayAtHotel stay = new StayAtHotel();
            var account = _clientService.GetClientAccountById(clientId);
            Console.WriteLine($"This is an account of {account.FirstName} {account.LastName}.");
            Console.WriteLine($"Your dog is {account.Dog.Name}");

            _reservationManagement.HowLongIsStay(account.Dog);

            _listOfStays.Add(stay);

        }
        public void AddNewStayForNewClient()
        {
            StayAtHotel stay = new StayAtHotel();

            var dog = _dogService.CreateDogAccount();
            _clientService.CreateClientAccount(dog);

            _reservationManagement.HowLongIsStay(dog);
            _listOfStays.Add(stay);

        }



        public List<StayAtHotel> GetStayList()
        {
            return _listOfStays;
        }

        public List<StayAtHotel> GetStayListByClient(int clientId)
        {
            List<StayAtHotel> clientStay = new List<StayAtHotel>();
            foreach (var stay in _listOfStays)
            {
                if (stay.Client.Id == clientId)
                {
                    clientStay.Add(stay);
                }
            }
            return clientStay;
        }
    }
}
