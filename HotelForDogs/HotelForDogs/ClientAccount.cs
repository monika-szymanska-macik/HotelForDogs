using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    class ClientAccount
    {
        private IList<Client> _clients;
        private IList<Dog> _dogs;

        public ClientAccount()
        {
            _clients = new List<Client>();
            _dogs = new List<Dog>();
        }
        public int GenerateDogId()
        {
            int id = 1;
            if (_dogs.Any())
            {
                id = _dogs.Max(x => x.Id) + 1;
            }
            return id;
        }
        public Dog CreateDogAccount()
        {
            Console.WriteLine("We need some information about your dog.");
            Console.WriteLine("Please enter a name of your dog:");
            string dogName = Console.ReadLine();
            Console.WriteLine("Please enter a breed of your dog:");
            string dogBreed = Console.ReadLine();
            Console.WriteLine("Please enter a weight of your dog:");
            string weightOfDog = Console.ReadLine();
            int weight;
            Int32.TryParse(weightOfDog, out weight);
            int id = GenerateDogId();
            Dog dog = new Dog(id, dogName, dogBreed, weight);
            _dogs.Add(dog);
            Console.WriteLine($"You added {dog.Name}");
            return dog;
        }
        public int GenerateClientId()
        {
            int id = 1;
            if (_clients.Any())
            {
                id = _clients.Max(x => x.Id) + 1;
            }
            return id;
        }
        public Client CreateClientAccount(Dog dog)
        {
            Console.WriteLine("Enter your name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();
            int id = GenerateClientId();
            Client account = new Client(id, firstName, lastName, phoneNumber, dog);
            
            _clients.Add(account);
            Console.WriteLine($"Accout for name: {account.FirstName}, last name: {account.LastName}, phone number: {account.PhoneNumber} is created. Your Client Number is {account.Id}");
            return account;
        }
        public Client GetClientAccountById(int clientId)
        {
            return _clients.Single(account => account.Id == clientId);
        }
        public void HowLongIsStay(Dog dog)
        {
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
