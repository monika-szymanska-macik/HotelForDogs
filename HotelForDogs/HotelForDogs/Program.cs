using System;

namespace HotelForDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            StayAtHotel stay = new StayAtHotel();

            while (true)
            {

                Console.WriteLine("I invite you to visit my Hotel for Dogs! You can spend your holidays not worrying about your dog.");
                Console.WriteLine("Do you have an account created in our hotel?");
                Console.WriteLine("Pleas enter Y for yes or N for no");
                string hotelClient = Console.ReadLine();
                if (hotelClient == "y" || hotelClient == "Y")
                {

                        Console.WriteLine("Please enter your Client Number");
                        string clientNumber = Console.ReadLine();
                        int clientId;
                        Int32.TryParse(clientNumber, out clientId);

                        stay.AddNewStay(clientId);

                }
                else if (hotelClient == "n" || hotelClient == "N")
                {
                    stay.AddNewStayForNewClient();
                }
                else
                {
                    Console.WriteLine("Value invalid;");
                }
                Console.WriteLine();
            }

        }
    }
}
