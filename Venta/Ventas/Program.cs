/*Utilice un arreglo de un subíndice para resolver el siguiente problema. Una empresa le paga a su
personal de ventas en base a comisión. Los vendedores reciben $200 por semana más 9 % de
sus ventas brutas de dicha semana. Por ejemplo, un vendedor que vende $3000 en ventas brutas,
en una semana recibe $200 más 9% de 3000 (270), o sea un total de $470. Escriba un programa
en C# (utilizando un arreglo de contadores) que determine cuántos de los vendedores ganaron
salarios en cada uno de los rangos siguientes (suponiendo que el salario de cada vendedor se
trunca a una cantidad entera):
1. $200 -$299
2. $300 -$399
3. $400 -$499
4. $500 -$599
5. $600 -$699
6. $700 -$799
7. $800 -$899
8. $900 -$999
9. $1000 o superior*/



using System;

class ProgramaVendedores
{
    static void Main()
    {
        // Definimos los contadores para los diferentes rangos salariales
        int[] contadores = new int[9]; // 9 rangos salariales, de $200 a $1000+

        // Lista de ventas brutas de los vendedores (puedes modificarla con los datos que necesites)
        double[] ventas = { 3000, 1500, 7000, 500, 2200, 10000 };

        foreach (double venta in ventas)
        {
            // Calculamos el salario del vendedor: salario fijo ($200) + 9% de las ventas brutas
            double salario = 200 + (0.09 * venta);
            int salarioEntero = (int)salario; // Truncamos el salario a un número entero

            // Determinamos en qué rango cae el salario y aumentamos el contador correspondiente
            if (salarioEntero >= 200 && salarioEntero <= 299)
            {
                contadores[0]++;
            }
            else if (salarioEntero >= 300 && salarioEntero <= 399)
            {
                contadores[1]++;
            }
            else if (salarioEntero >= 400 && salarioEntero <= 499)
            {
                contadores[2]++;
            }
            else if (salarioEntero >= 500 && salarioEntero <= 599)
            {
                contadores[3]++;
            }
            else if (salarioEntero >= 600 && salarioEntero <= 699)
            {
                contadores[4]++;
            }
            else if (salarioEntero >= 700 && salarioEntero <= 799)
            {
                contadores[5]++;
            }
            else if (salarioEntero >= 800 && salarioEntero <= 899)
            {
                contadores[6]++;
            }
            else if (salarioEntero >= 900 && salarioEntero <= 999)
            {
                contadores[7]++;
            }
            else if (salarioEntero >= 1000)
            {
                contadores[8]++;
            }
        }

        // Mostramos los resultados
        Console.WriteLine("Salarios en los diferentes rangos:");
        Console.WriteLine("$200-$299: " + contadores[0]);
        Console.WriteLine("$300-$399: " + contadores[1]);
        Console.WriteLine("$400-$499: " + contadores[2]);
        Console.WriteLine("$500-$599: " + contadores[3]);
        Console.WriteLine("$600-$699: " + contadores[4]);
        Console.WriteLine("$700-$799: " + contadores[5]);
        Console.WriteLine("$800-$899: " + contadores[6]);
        Console.WriteLine("$900-$999: " + contadores[7]);
        Console.WriteLine("$1000 o superior: " + contadores[8]);
    }
}

