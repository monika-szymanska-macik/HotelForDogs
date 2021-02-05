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
            
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Weight { get; set; }
        //private int GenerateDogId()
        //{
        //    int id = 1;
        //    if (_dogs.Any())
        //    {
        //        id = _dogs.Max(x => x.Id) + 1;
        //    }
        //    return id;
        //}
        //public Dog CreateDogAccount(int id, string name, string breed, int weight)
        //{
        //    int dogId = GenerateDogId();
        //    Dog dog = new Dog(dogId, name, breed, weight);
        //    _dogs.Add(dog);
        //    Console.WriteLine($"Your Client Number is {dog.Id}");
        //    return dog;
        //}
        //private List<Dog> _dogs;
    }
}
