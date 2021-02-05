using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class ClientService
    {
        public List<Client> Clients { get; set; }
        public ClientService()
        {
            Clients = new List<Client>();
        }
    }
}
