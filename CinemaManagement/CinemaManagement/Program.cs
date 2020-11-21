using System;

namespace CinemaManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema1 = new Cinema("SciFi_Cinema", 2);

            Hall hall1 = new Hall("Hall_1", 2, 3);
            Hall hall2 = new Hall("Hall_2", 2, 3);
            Hall hall3 = new Hall("Hall_3", 2, 3);

            hall1.ReserveSeat(1, 1);
            hall1.ReserveSeat(1, 1);

            cinema1.AddHall(hall1);
            cinema1.AddHall(hall2);
            cinema1.AddHall(hall3);
        }
    }
}
