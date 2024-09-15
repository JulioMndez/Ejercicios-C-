/*(Sistema de Reservaciones de Aerolínea). Una pequeña aerolínea acaba de adquirir una
computadora para su sistema automatizado de reservaciones. El presidente de la aerolínea, le
ha solicitado a usted que programe el nuevo sistema en C#. Usted debe escribir un programa que
asigne asientos en cada vuelo del único avión de la aerolínea (capacidad: 10 asientos).
Su programa deberá mostrar el siguiente menú de alternativas:
Please type 1 for "smoking"
Please type 2 for "nonsmoking"
Si la persona digita 1, entonces su programa deberá asignar un asiento en la sección de fumar
(asientos 1 al 5). Si la persona digita 2, entonces su programa deberá de asignar un asiento en
la sección de no fumar (asientos 6 al 10). Su programa a continuación, deberá imprimir un pase
de abordaje, indicando el número de asiento de la persona y si está en la sección fumar o de no
fumar del aeroplano.
Su programa no deberá, naturalmente, asignar nunca un asiento que ya haya sido asignado.
Cuando esté llena la sección de fumar, su programa deberá solicitar a la persona, si le parece
aceptable ser colocada en la sección de no fumar (o viceversa). Si dice que sí, entonces efectúe
la asignación apropiada de asiento. Si dice que no, entonces imprima el mensaje "Next flight
leaves in 3 hours".
Ejercicio 3*/




using System;

class SistemaReservacionAerolínea
{
    static void Main()
    {
        bool[] asientos = new bool[10]; // Arreglo para almacenar la disponibilidad de los 10 asientos (falso = libre, verdadero = ocupado)
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Please type 1 for 'smoking'");
            Console.WriteLine("Please type 2 for 'nonsmoking'");
            int seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                // Intentar asignar un asiento en la sección de fumar (1 a 5)
                bool asignado = AsignarAsiento(asientos, 0, 4);

                if (!asignado)
                {
                    Console.WriteLine("La sección de fumar está llena. ¿Le gustaría estar en la sección de no fumar? (1 = sí, 2 = no)");
                    int respuesta = int.Parse(Console.ReadLine());
                    if (respuesta == 1)
                    {
                        AsignarAsiento(asientos, 5, 9);
                    }
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                    }
                }
            }
            else if (seleccion == 2)
            {
                // Intentar asignar un asiento en la sección de no fumar (6 a 10)
                bool asignado = AsignarAsiento(asientos, 5, 9);

                if (!asignado)
                {
                    Console.WriteLine("La sección de no fumar está llena. ¿Le gustaría estar en la sección de fumar? (1 = sí, 2 = no)");
                    int respuesta = int.Parse(Console.ReadLine());
                    if (respuesta == 1)
                    {
                        AsignarAsiento(asientos, 0, 4);
                    }
                    else
                    {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                    }
                }
            }

            // Verificar si todos los asientos están ocupados
            if (Array.TrueForAll(asientos, asiento => asiento))
            {
                Console.WriteLine("Todos los asientos están ocupados. El próximo vuelo sale en 3 horas.");
                continuar = false;
            }
        }
    }

    // Método para asignar un asiento
    static bool AsignarAsiento(bool[] asientos, int inicio, int fin)
    {
        for (int i = inicio; i <= fin; i++)
        {
            if (!asientos[i])
            {
                asientos[i] = true;
                Console.WriteLine($"Asiento asignado: {i + 1}. {(i < 5 ? "Sección de fumar" : "Sección de no fumar")}");
                return true;
            }
        }
        return false;
    }
}

