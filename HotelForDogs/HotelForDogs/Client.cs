using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    public class Client
    {
        public Client()
        {

        }

        public Client(int id, string firstName, string lastName, string phoneNumber, Dog dog)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Dog = dog;


        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        private string _lastName { get; set; }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string PhoneNumber { get; set; }
        public Dog Dog { get; set; }

 


    }
}
