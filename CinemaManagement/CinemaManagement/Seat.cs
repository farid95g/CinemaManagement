using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaManagement
{
    class Seat
    {
        public int Row;
        public int Column;
        public bool Status = true;

        public Seat(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public override string ToString()
        {
            return $"The seat in the row {Row} and in the column {Column} {(Status ? "is free" : "has been sold.")}";
        }
    }
}
