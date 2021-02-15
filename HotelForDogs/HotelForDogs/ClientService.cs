using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    class ClientService
    {
        private IList<Client> _clients;
        public ClientService()
            {
            _clients = new List<Client>();
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
