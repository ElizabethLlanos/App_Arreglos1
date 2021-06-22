using System;

namespace Aplicacion1Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancia
            Numeros objNumero = new Numeros();
            //Array para guardar los datos otorgados por el usuario
            int[] Num = new int[10];
            Console.WriteLine("♠♠♠♠♠ NÚMEROS ENTEROS♠♠♠♠♠");
            Console.WriteLine(">Introduce 10 números:");
            //Con el ciclo for se recibirán los números y se guardarán en el array
            for(int j = 0; j < 10; j++)
            {
                Console.Write("► ");
                Num[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            //Llamada al método suma
            int suma = objNumero.Suma(Num) ;
            Console.WriteLine($"►La suma de los numeros anteriores es: {suma}");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            //Llamada al método promedio
            int promedio = objNumero.Promedio(Num);
            Console.WriteLine($"►El promedio es: {promedio}");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            //Llamada al método Num_mayor
            int num_mayor = objNumero.Num_mayor(Num);
            Console.WriteLine($"►El numero mayor es: {num_mayor}");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");
            //Llamada al método Num_menor
            int num_menor = objNumero.Num_menor(Num);
            Console.WriteLine($"►El numero menor es: {num_menor}");
            Console.WriteLine("♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦♦");

            Console.ReadKey();

        }
    }
}
