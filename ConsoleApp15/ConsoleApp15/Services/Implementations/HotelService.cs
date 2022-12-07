using ConsoleApp15.Model;
using ConsoleApp15.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp15.Services.Implementations
{
    internal class HotelService : IHotelService
    {
        Room[] rooms = new Room[0];

        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length+1);
            if(rooms[rooms.Length-1] == null)
            {
                rooms[rooms.Length - 1] = room;
            }
        }
        public void MakeReservation(int? id)
        {
            foreach (var item in rooms)
            {
                if (id == null)
                {
                    throw new NullReferenceException("NullReferenceException");
                }
                if (id == item.Id)
                {
                    if (item.IsAvailable == true)
                    {
                        item.IsAvailable = false;
                        Console.WriteLine("Reserv olundu");
                    }
                    else
                    {
                        throw new NullReferenceException("NullReferenceException");
                    }
                }
            }
        }
    }
}
