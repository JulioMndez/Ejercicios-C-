using System;

/*Utilice un arreglo de doble subíndice para resolver el siguiente problema. Una empresa tiene
cuatro vendedores (1 a 4) que venden cinco productos diferentes (1 a 5). Una vez al día, cada
vendedor emite un volante para cada tipo distinto de producto vendido. Cada volante contiene:
1.El número del vendedor.
2. El número del producto.
3. El valor total en dólares del producto vendido ese día.
Por lo tanto, cada vendedor entrega por día entre 0 y 5 volantes de ventas. Suponga que está
disponible la información de todos los volantes correspondientes al mes anterior. Escriba un
programa que lea toda esta información correspondiente a las ventas del mes anterior, y que
resuma las ventas totales por vendedor y por producto. Todos los totales deberán almacenarse
en un arreglo de doble subíndice (sales). Después de procesar toda la información
correspondiente al mes anterior, imprima los resultados en forma tabular, con cada una de las 
columnas representando a un vendedor en particular y cada uno de los renglones representando
un producto en particular. Totalice en forma cruzada cada renglón, para obtener las ventas totales
de cada producto del mes pasado; totalice cada columna para obtener las ventas totales por
vendedor correspondiente al mes pasado. Su impresión en forma tabular, deberá incluir estos
totales a la derecha de los renglones totalizados y en la parte inferior de las columnas totalizadas.*/




class VentasVendedores
{
    static void Main()
    {
        // Definimos una matriz donde las filas son los vendedores (4 vendedores) y las columnas son los productos (5 productos)
        decimal[,] ventas = new decimal[4, 5];

        // Lectura de datos
        Console.WriteLine("Ingrese la cantidad de volantes (ventas) para procesar:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Volante {i + 1}:");
            Console.Write("Número de vendedor (1 a 4): ");
            int vendedor = int.Parse(Console.ReadLine()) - 1; // Convertir a índice 0
            Console.Write("Número de producto (1 a 5): ");
            int producto = int.Parse(Console.ReadLine()) - 1; // Convertir a índice 0
            Console.Write("Valor total en dólares del producto vendido: ");
            decimal valorVenta = decimal.Parse(Console.ReadLine());

            // Acumular las ventas en la matriz
            ventas[vendedor, producto] += valorVenta;
        }

        // Mostrar la tabla de resultados
        Console.WriteLine("\nVentas totales por vendedor y producto:\n");

        // Imprimir encabezados de productos
        Console.Write("\t\t");
        for (int p = 1; p <= 5; p++)
        {
            Console.Write($"Producto {p}\t");
        }
        Console.WriteLine("Total por vendedor");

        // Imprimir filas con vendedores y productos
        for (int v = 0; v < 4; v++)
        {
            decimal totalVendedor = 0;
            Console.Write($"Vendedor {v + 1}\t");

            for (int p = 0; p < 5; p++)
            {
                Console.Write($"{ventas[v, p]:F2}\t\t");
                totalVendedor += ventas[v, p]; // Total por vendedor
            }

            Console.WriteLine($"{totalVendedor:F2}"); // Total por vendedor al final de la fila
        }

        // Imprimir total por producto
        Console.Write("\nTotal por producto\t");
        for (int p = 0; p < 5; p++)
        {
            decimal totalProducto = 0;
            for (int v = 0; v < 4; v++)
            {
                totalProducto += ventas[v, p];
            }
            Console.Write($"{totalProducto:F2}\t\t");
        }
    }
}

