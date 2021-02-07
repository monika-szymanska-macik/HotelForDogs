using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    public class Dog 
    {
        public Dog(int id, string name, string breed, int weight)
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
        
        
        
        public List<Dog> Dogs;
    }
}
