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
            Console.WriteLine("Please enter the day of arrival of your dog: ");
            Console.WriteLine("(for example: 31-01-2021)");

            string startDay = Console.ReadLine();
            DateTime firstDay;
            DateTime.TryParse(startDay, out firstDay);

            Console.WriteLine("Please enter the day of departure of your dog");

            string dayEnd = Console.ReadLine();
            DateTime lastDay;
            DateTime.TryParse(dayEnd, out lastDay);
            listOfStays.Add(stay);
            int lengthOfStay = DayNumberOfStay(firstDay, lastDay);
            Console.WriteLine($"Your dog will stay with us for {lengthOfStay} days");
            decimal price = Price(lengthOfStay, account.Dog.Weight);
            Console.WriteLine($"The cost of the stay is {price} PLN");
            listOfStays.Add(stay);        

        }
        public void AddNewStayForNewClient()
        {
            StayAtHotel stay = new StayAtHotel();
            
            var dog = _clientAccount.CreateDogAccount();
            _clientAccount.CreateClientAccount(dog);
            Console.WriteLine("Please enter the day of arrival of your dog: ");
            Console.WriteLine("(for example: 31-01-2021)");

            string startDay = Console.ReadLine();
            DateTime firstDay;
            DateTime.TryParse(startDay, out firstDay);

            Console.WriteLine("Please enter the day of departure of your dog");

            string dayEnd = Console.ReadLine();
            DateTime lastDay;
            DateTime.TryParse(dayEnd, out lastDay);          
            int lengthOfStay = DayNumberOfStay(firstDay, lastDay);
            Console.WriteLine($"Your dog will stay with us for {lengthOfStay} days");
            decimal price = Price(lengthOfStay, dog.Weight);
            Console.WriteLine($"The cost of a {dog.Name} stay is {price} PLN");
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
