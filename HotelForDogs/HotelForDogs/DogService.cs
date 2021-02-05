using System;
using System.Collections.Generic;
using System.Text;

namespace HotelForDogs
{
    class DogService
    {
        public List<Dog> Dogs { get; set; }
        public DogService()
        {
            Dogs = new List<Dog>();
        }
    }
}
