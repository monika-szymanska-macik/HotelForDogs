using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelForDogs
{
    public class DogService
    {
        private IList<Dog> _dogs;
        public DogService()
        {
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
            Int32.TryParse(weightOfDog, out int weight);
            int id = GenerateDogId();
            Dog dog = new Dog(id, dogName, dogBreed, weight);
            _dogs.Add(dog);
            Console.WriteLine($"You added {dog.Name}");
            return dog;
        }
    }

}
