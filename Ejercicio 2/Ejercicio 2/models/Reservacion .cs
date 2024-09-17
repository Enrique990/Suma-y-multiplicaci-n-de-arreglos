using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.model
{
    internal class Reservacion
    {
        private const int TOTAL_SEATS = 10;
        private const int SMOKING_SEATS = 5;
        private const int NON_SMOKING_SEATS = 5;
        private bool[] seats = new bool[TOTAL_SEATS];

        public (int seatNumber, bool isSmoking)? AsignarAsiento(bool isSmoking)
        {
            int start = isSmoking ? 0 : SMOKING_SEATS;
            int end = isSmoking ? SMOKING_SEATS : TOTAL_SEATS;

            for (int i = start; i < end; i++)
            {
                if (!seats[i])
                {
                    seats[i] = true;
                    return (i + 1, isSmoking);
                }
            }
            return null;
        }

        public bool SeccionLlena(bool isSmoking)
        {
            int start = isSmoking ? 0 : SMOKING_SEATS;
            int end = isSmoking ? SMOKING_SEATS : TOTAL_SEATS;

            for (int i = start; i < end; i++)
            {
                if (!seats[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
