using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagement
{
    class Cinema
    {
        public string Name { get; set; }
        private Hall[] Halls = { };
        private int maxHallNumber;

        // assigning values to properties when the object is created
        public Cinema(string name, int maxNumber)
        {
            Name = name;
            maxHallNumber = maxNumber;
        }

        // method for adding a hall to cinema
        public void AddHall(Hall hall)
        {
            if (Halls.Length < maxHallNumber)  // as the resize is after this statement, then we use less than operator instead of less than or equal to
            {
                Array.Resize(ref Halls, Halls.Length + 1);
                Halls[Halls.Length - 1] = hall;
                Console.WriteLine($"The hall {hall.Name} has been successfully added to the cinema {Name}.");
            }
            else
            {
                Console.WriteLine($"There is no empty place to add a new hall to the cinema {Name}.");
            }
        }

        public override string ToString()
        {
            return $"The name of the cinema is \"{Name}\" and it can have maximum {Halls.Length} halls.";
        }
    }
}
