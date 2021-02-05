using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    class StayAtHotel
    {
        private IList<Client> _clients;
        public StayAtHotel()
        {
            _clients = new List<Client>();
            _dogs = new List<Dog>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int dogId { get; set; }

        private List<Dog> _dogs;


        List<StayAtHotel> listOfStays = new List<StayAtHotel>();

        public void AddNewStay(int clientId)
        {
            StayAtHotel stay = new StayAtHotel();
            Console.WriteLine("We need some information about your dog.");
            Console.WriteLine("Please enter a name of your dog:");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please enter a breed of your dog:");
            string breed = Console.ReadLine();
            Console.WriteLine("Please enter a weight of your dog:");
            string weightOfDog = Console.ReadLine();
            int weight;
            Int32.TryParse(weightOfDog, out weight);
            stay.CreateDogAccount(dogName, breed, weight);
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
            decimal price = Price(lengthOfStay, weight);
            Console.WriteLine($"The cost of the stay is {price} PLN");
            listOfStays.Add(stay);        

        }
        public void AddNewStayForNewClient()
        {
            CreateClientAccount();
            StayAtHotel stay = new StayAtHotel();
            Console.WriteLine("We need some information about your dog.");
            Console.WriteLine("Please enter a name of your dog:");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please enter a breed of your dog:");
            string breed = Console.ReadLine();
            Console.WriteLine("Please enter a weight of your dog:");
            string weightOfDog = Console.ReadLine();
            int weight;
            Int32.TryParse(weightOfDog, out weight);
            stay.CreateDogAccount(dogName, breed, weight);
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
            decimal price = Price(lengthOfStay, weight);
            Console.WriteLine($"The cost of the stay is {price} PLN");

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
                if (stay.ClientId == clientId)
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
            decimal price = 0.0M;


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
        private int GenerateClientId()
        {
            int id = 1;
            if (_clients.Any())
            {
                id = _clients.Max(x => x.Id) + 1;
            }
            return id;
        }
        public Client CreateClientAccount()
        {
            int id = GenerateClientId();
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();
            Client account = new Client(id, firstName, lastName, phoneNumber);
            _clients.Add(account);
            Console.WriteLine($"Accout for name: {account.FirstName}, last name: {account.LastName}, phone number: {account.PhoneNumber} is created. Your Client Number is {account.Id}");
            return account;
        }
        private int GenerateDogId()
        {
            int id = 1;
            if (_dogs.Any())
            {
                id = _dogs.Max(x => x.Id) + 1;
            }
            return id;
        }
        public Dog CreateDogAccount(string name, string breed, int weight)
        {
            int dogId = GenerateDogId();
            Dog dog = new Dog(dogId, name, breed, weight);
            _dogs.Add(dog);
            Console.WriteLine($"Your Dog Number is {dog.Id}");
            return dog;
        }
       
    }
}
