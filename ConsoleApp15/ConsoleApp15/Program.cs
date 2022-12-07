using ConsoleApp15.Model;
using ConsoleApp15.Services.Implementations;
using System;
using static ConsoleApp15.Exeptions.Exeption;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("25",500,3,true);
            Room room2 = new Room("30", 100, 2, false);
            Hotel hotel = new Hotel("Hotel");
            HotelService hotelService = new HotelService();

            hotelService.AddRoom(room1);    
            hotelService.AddRoom(room2);
            room1.ShowInfo();
            room2.ShowInfo();
            try
            {
                hotelService.MakeReservation(1);
            }
            catch (NullReferanceException exx)
            {
                Console.WriteLine(exx.Message);
                throw;
            }
        }
    }
}
