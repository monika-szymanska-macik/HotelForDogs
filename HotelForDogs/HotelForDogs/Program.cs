using System;

namespace HotelForDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            StayAtHotelService stayAtHotelService = new StayAtHotelService();

            while (true)
            {

                Console.WriteLine("I invite you to visit my Hotel for Dogs! You can spend your holidays not worrying about your dog.");
                Console.WriteLine("Do you have an account created in our hotel?");
                Console.WriteLine("Pleas enter Y for yes or N for no");
                string hotelClient = Console.ReadLine();
                switch (hotelClient.ToLower())
                {
                    case "y":

                        Console.WriteLine("Please enter your Client Number");
                        string clientNumber = Console.ReadLine();
                        Int32.TryParse(clientNumber, out int clientId);
                        if (clientId == 0 || clientId == null)
                        {
                            Console.WriteLine("Value invalid");
                        }
                        stayAtHotelService.AddNewStay(clientId);
                        break;
                    case "n":
                        stayAtHotelService.AddNewStayForNewClient();
                        break;
                    default:
                        Console.WriteLine("Value invalid");
                        break;
                }

            Console.WriteLine();
            }

        }
    }
}
