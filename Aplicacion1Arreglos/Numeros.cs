using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion1Arreglos
{
    class Numeros
    {
        //Atributos
        private int suma;
        //Método para sumar los números, se recibe el array por parámetro
        public int Suma(int[] Num)
        {
            //Se crea un array con 10 espacios
            int[] numero = new int[10];
            //se rellena el array con los datos recibidos por parámetro
            numero = Num;
            suma = 0;
            //Se utiliza un for para recorrer y sumar los datos del array
            for(int i = 0; i < 10; i++)
            {
                suma += numero[i];
            }
            return suma;
        }
        //Método para calcular promedio
        public int Promedio(int[] Num)
        {
            int[] numero = new int[10];
            numero = Num;
            int promedio = 0;
            //Se calcula el promedio
            promedio = suma / 10;

            return promedio;
        }
        //Método para encontrar el número mayor
        public int Num_mayor(int[] Num)
        {
            int[] numero = new int[10];
            numero = Num;
            int num_mayor = 0;
            //Se ordenan los datos del array de menor a mayor
            Array.Sort(numero);
            //El mayor será el de la última posición
            num_mayor = numero[9];

            return num_mayor;
        }
        //Método para encontrar el número menor
        public int Num_menor(int[] Num)
        {
            int[] numero = new int[10];
            numero = Num;
            int num_menor = 0;
            //Se ordenan los numeros de menor a mayor
            Array.Sort(numero);
            //El menor será el de la primera posición
            num_menor = numero[0];

            return num_menor;
        }


    }
}
