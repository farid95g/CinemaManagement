using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagement
{
    class Cinema
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        private Hall[] Halls = { };
        private int maxHallNumber;

        // assigning values to properties when the object is created
        public Cinema(string name, int maxNumber)
        {
            _id++;
            Id = _id;
            Name = name;
            maxHallNumber = maxNumber;
        }

        // method for adding a hall to cinema
        public void AddHall(Hall hall)
        {
            Array.Resize(ref Halls, Halls.Length + 1);
            Halls[Halls.Length - 1] = hall;
        }

        public override string ToString()
        {
            return $"The id of the cinema \"{Name}\" is {Id}. This cinema can have maximum {maxHallNumber} halls.";
        }
    }
}
