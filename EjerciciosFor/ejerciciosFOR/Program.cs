// See https://aka.ms/new-console-template for more information

//Ejercicio1:
//El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese 5 valores enteros:");
//        int suma = 0;
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.Write($"Valor {i}: ");
//            if (int.TryParse(Console.ReadLine(), out int numero))
//            {
//                suma += numero;
//            }
//            else
//            {
//                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
//                i--;
//            }
//        }
//        Console.WriteLine($"La suma de los 5 numeros es: {suma}");
//    }
//}

//Ejercicio2:
//Se necesita calcular el promedio de 8 números ingresados por el usuario.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese un numero: ");
//        int suma = 0;
//        for (int i = 1; i <= 8; i++)
//        {
//            Console.WriteLine($"Valor {i}: ");
//            if (int.TryParse(Console.ReadLine(), out int numero))
//            {
//                suma += numero;
//            }
//            else
//            {
//                Console.WriteLine("Entrada invalida. Por favor ingrese un numero valido");
//                i--;
//            }
//        }
//        float promedio = (float)suma / 8;
//        Console.WriteLine($"El promedio de los 8 numero es {promedio}:");
//    }
//}
//Ejercicio3:
//Para calcular el total de una factura, el usuario ingresará pares de datos Costo unitario y cantidad comprada; de unas 5 compras; Informar el total adeudado.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese la cantidad de unidades compradas:");
//        double totalcosto = 0;
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.Write($"Compra {i} - Ingrese la cantidad de unidades compradas : ");
//            if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int unidades))
//            {
//                Console.Write($"Compra {i} - Costo unitario: ");
//                if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double costo))
//                {
//                    totalcosto += unidades * costo;
//                }
//                else
//                {
//                    Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
//                    i--;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Entrada inválida. Por favor ingrese un número válido.");
//                i--;
//            }
//        }
//        Console.WriteLine($"La suma de las 5 compras es: {totalcosto}");
//    }
//}

//Ejercicio4:
//De una lista de 8 números indicar cual es el mayor.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese ocho numeros: ");
//        int max = int.MinValue;
//        for (int i = 1; i <= 8; i++)
//        {
//            Console.WriteLine($"Numero {i}");
//            if (int.TryParse(Console.ReadLine(), out int numero))
//            {
//                if (numero > max)
//                {
//                    max = numero;
//                }
//            }
//            else
//            {
//                Console.WriteLine("Entrada invalida. Por favor ingrese un numero valido");
//                i--;
//            }
//        }
//        Console.WriteLine($"El numero mayor de los 8 numero es {max}:");
//    }
//}
//Ejercicio5:
//El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más. 
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese el nombre del cliente y su gasto total: ");
//        double gastomayor = 0;
//        string clientemayor = "";
//        for (double i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Ingrese el nombre del cliente: ");
//            string cliente = Console.ReadLine();
//            if (string.IsNullOrWhiteSpace(cliente) || double.TryParse(cliente, out _))
//            {
//                Console.WriteLine("Dato incorrecto, ingrese el nombre del cliente: ");
//                i--;
//            }
//            else
//            {
//                Console.WriteLine("Ingrese su gasto total: ");
//                if (double.TryParse(Console.ReadLine()?.Replace(".", ","), out double gasto))
//                {
//                    if (gasto > gastomayor)
//                    {
//                        gastomayor = gasto;
//                        clientemayor = cliente;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine($"ERROR, ingrese nuevamente el gasto total: ");
//                    i--;
//                }
//            }
//        }
//        Console.WriteLine($"El cliente que tiene el mayor gasto es {clientemayor}");
//
//    }
//}

//Ejercicio6:
//El usuario ingresa un número N y se debe mostrar como resultado el factorial de dicho número.
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Ingrese un numero entero positivo y se mostraran todos los numeros enteros positivos pares desde el 0 hasta el elegido");
//        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int entero))
//        {
//            for (int i = 0; i <= entero; i += 2)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Entrada incorrecta ");
//        }
//    }
//}

//Ejercicio7:
//El usuario ingresa un número entero positivo N y se deben mostrar todos los números enteros positivos pares desde 0 (incluido) hasta N.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un numero entero positivo y se mostraran todos los numeros enteros positivos pares desde el 0 hasta el elegido");
        if (int.TryParse(Console.ReadLine()?.Replace(".", ","), out int entero))
        {
            for (int i = 0; i <= entero; i += 2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada incorrecta ");
        }
    }
}

