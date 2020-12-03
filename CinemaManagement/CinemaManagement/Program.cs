using System;

namespace CinemaManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("To create a new cinema, please, enter the name of the cinema: ");
            string name = Console.ReadLine();
            Console.Write("Please, enter the number of the halls for the newly created cinema: ");
            int hallQuantity = Convert.ToInt32(Console.ReadLine());
            Cinema cinema1 = new Cinema(name, hallQuantity);

            Hall hall1 = new Hall("Hall_1", 2, 3);
            Hall hall2 = new Hall("Hall_2", 2, 3);
            Hall hall3 = new Hall("Hall_3", 2, 3);

            hall1.ReserveSeat(1, 1);  // You have reserved the seat in the row 1 and in the column 1.
            hall1.ReserveSeat(1, 1);  // Sorry, the seat in the row 1 and column 1 has been already reserved.

            cinema1.AddHall(hall1);  // The hall Hall_1 has been successfully added to the cinema SciFi_Cinema.
            cinema1.AddHall(hall2);  // The hall Hall_2 has been successfully added to the cinema SciFi_Cinema.
            cinema1.AddHall(hall3);  // There is no empty place to add a new hall to the cinema SciFi_Cinema.

            hall1.BuySeat(1, 1);
            hall1.BuySeat(2, 2);
            hall1.BuySeat(2, 2);
        }
    }
}
