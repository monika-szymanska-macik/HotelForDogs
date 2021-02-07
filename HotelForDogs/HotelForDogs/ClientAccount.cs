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

    }
}
