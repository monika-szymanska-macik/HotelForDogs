using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotel
    {
        private ClientAccount _clientAccount;
        public StayAtHotel()
        {
            _clientAccount = new ClientAccount();   
            _dogs = new List<Dog>();
        }

        public int Id { get; set; }
        public Client Client { get; set; }


        private List<Dog> _dogs;


        List<StayAtHotel> listOfStays = new List<StayAtHotel>();

        public void AddNewStay(int clientId)
        {
            StayAtHotel stay = new StayAtHotel();
            var account = _clientAccount.GetClientAccountById(clientId);
            Console.WriteLine($"This is an account of {account.FirstName} {account.LastName}.");
            Console.WriteLine($"Your dog is {account.Dog.Name}");

            _clientAccount.HowLongIsStay(account.Dog);

            listOfStays.Add(stay);        

        }
        public void AddNewStayForNewClient()
        {
            StayAtHotel stay = new StayAtHotel();

            var dog = _clientAccount.CreateDogAccount();
            _clientAccount.CreateClientAccount(dog);

            _clientAccount.HowLongIsStay(dog);
            listOfStays.Add(stay);

        }

        

        public List<StayAtHotel> GetStayList()
        {
            return listOfStays;
        }

        public List<StayAtHotel> GatStayListByClient(int clientId)
        {
            List<StayAtHotel> clientStay = new List<StayAtHotel>();
            foreach (var stay in listOfStays)
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
