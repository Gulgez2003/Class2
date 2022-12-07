using ConsoleApp15.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Services.Interfaces
{
    internal interface IHotelService
    {
        public void AddRoom(Room room);
        public void MakeReservation(int? id);
    }
}
