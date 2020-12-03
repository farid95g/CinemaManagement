using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagement
{
    class Seat
    {
        public int Row;
        public int Column;
        public string Status;
        public enum StatusOptions
        {
            free,
            reserved,
            sold
        }

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
            Status = StatusOptions.free.ToString();
        }

        public override string ToString()
        {
            return $"The seat in the row {Row} and in the column {Column} {(Status == "free" ? "is free" : $"has been {Status}.")}";
        }
    }
}
