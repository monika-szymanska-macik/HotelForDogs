using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    abstract class Dog
    {
        protected Dog(int id, string name, string breed, int weight)
        {
            Id = id;
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
    }
}
