using ConsoleApp15.Model.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Model
{
    internal class Room:Base
    {
        private static int _id = 0;

        public int Id { get; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string name,int price, int personCapacity,bool isAvailable):base(name)
        {
            _id++;
            Id = _id;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = isAvailable;
        }
        public string ShowInfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return ("Id: "+Id+" Name"+Name+"Price"+Price+"PersonCapacity"+PersonCapacity+"IsAvailable"+IsAvailable).ToString();
        }
    }
}
