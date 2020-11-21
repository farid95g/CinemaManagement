using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagement
{
    class Hall
    {
        public string Name { get; set; }
        public Seat[,] Seats;

        public Hall(string name, int row, int column)
        {
            Name = name;
            Seats = new Seat[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Seats[i, j] = new Seat(i + 1, j + 1);
                }
            }
        }

        // showing all seats
        public void ShowAllSeats()
        {
            for (int i = 0; i < Seats.GetLength(0); i++)  // returns the length of the row
            {
                for (int j = 0; j < Seats.GetLength(1); j++)  // returns the length of the column
                {
                    Console.WriteLine(Seats[i, j]);
                }
            }
        }

        //reserve a seat
        public void ReserveSeat(int row, int column)
        {
            if (Seats[row - 1, column - 1].Status)
            {
                Seats[row - 1, column - 1].Status = false;
                Console.WriteLine($"You have reserved the seat in the row {row} and in the column {column}.");
            }
            else
            {
                Console.WriteLine($"Sorry, the seat in the row {row} and column {column} has been already reserved.");
            }
        }
    }
}
