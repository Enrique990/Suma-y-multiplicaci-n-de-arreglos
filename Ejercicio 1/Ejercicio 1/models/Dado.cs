using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.models
{
    internal class Dado
    {
        private static Random rand = new Random();

        public int Lanzar()
        {
            return rand.Next(1, 7);
        }
    }

    internal class Repetidor
    {
        public int[] frecuencia; 
        public Dado dado1;
        public Dado dado2;


        public Repetidor()
        {
            frecuencia = new int[13]; 
            dado1 = new Dado();
            dado2 = new Dado();
        }
        public void Reinicio()
        {
            frecuencia = new int[13]; 
        }
        public void Tiradas(int lanzamientos)
        {
            Reinicio();
            for (int i = 0; i < lanzamientos; i++)
            {
                int suma = dado1.Lanzar() + dado2.Lanzar();
                frecuencia[suma]++;
            }
        }

        public int[] GetFrecuencias()
        {
            return frecuencia;
        }
    }
}