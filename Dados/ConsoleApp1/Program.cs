/* Escriba un programa en C#, que simule el tirar dos dados. El programa deberá utilizar la función
rand para tirar el primer dado, y después volverá a utilizar la función rand para tirar el segundo.
suma de los valores deberá entonces ser calculada. Nota: en vista de que cada dado puede
mostrar un valor entero de 1 a 6, entonces la suma de los dos valores variará desde 2 hasta 12,
siendo 7 la suma mas frecuente y 2 y 12 las menos frecuentes. En la siguiente figura, se muestran
las 36 combinaciones posibles de los dos dados. Su programa deberá tirar 36,000 veces los dos
dados. Utilice un arreglo de un subíndice para llevar cuenta del número de veces que aparece
cada suma posible. Imprima los resultados en un formato tabular. También determine si los totales
son razonables, es decir, existen seis formas de llegar a un 7, por lo que aproximadamente una
sexta parte de todas las tiradas deberán ser 7.*/

using System;

class ProgramaSimulacionDados
{
    static void Main()
    {
        Random rand = new Random();
        int[] sumas = new int[13]; // Arreglo para contar las veces que aparece cada suma (de 2 a 12)
        int tiradas = 36000;

        // Simulación de 36,000 lanzamientos de dados
        for (int i = 0; i < tiradas; i++)
        {
            int dado1 = rand.Next(1, 7); // Primer dado (valores de 1 a 6)
            int dado2 = rand.Next(1, 7); // Segundo dado (valores de 1 a 6)
            int suma = dado1 + dado2;
            sumas[suma]++;
        }

        // Imprimir resultados en formato tabular
        Console.WriteLine("Suma\tVeces que aparece\tFrecuencia (%)");
        for (int i = 2; i <= 12; i++)
        {
            double frecuencia = (double)sumas[i] / tiradas * 100;
            Console.WriteLine($"{i}\t{sumas[i]}\t\t\t{frecuencia:F2}%");
        }

        // Verificar si la frecuencia de la suma 7 es razonable
        Console.WriteLine("\nVerificación de la suma 7:");
        Console.WriteLine($"La suma 7 apareció {sumas[7]} veces.");
        Console.WriteLine($"Se esperaba que apareciera aproximadamente {tiradas / 6} veces.");
    }
}

