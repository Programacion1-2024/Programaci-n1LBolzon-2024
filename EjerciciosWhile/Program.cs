﻿// See https://aka.ms/new-console-template for more information
//Ejercicios WHILE

//Ejercicio 1 El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero).El sistema deberá informar la suma de los ingresados.

/*
class Program
{
    static void Main(string[] Args)
    {
        Console.WriteLine("Ingrese los numeros positivos que desee sumar, para finalizar ingrese un 0 ");
        double suma = 0;
        double numero = 1;
        while( numero != 0) //el programa se ejecuta mientras el numero ingresado sea distinto de 0
        {
            if (double.TryParse(Console.ReadLine()?.Replace (",", "."), out numero)) //en este if se verifica que ingrese un numero y no una cadena de texto, uso double para que lea los numeros con coma
            {
                if(numero >= 0) //este if es para que el usuario no pueda ingresar valores negativos
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("entrada invalida, ingrese un numero positivo");
                    numero = 1;
                }
            }
            else
            {
                    Console.WriteLine("entrada invalida, ingrese un numero ");
                    numero = 1;
                
            }
            
        }
         Console.WriteLine($"la suma de los valores ingresados es: {suma}");
    }
}
*/


//Ejercicio 2 Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados.

/*
class Program
{
    static void Main(string[] Args)
    {
        Console.WriteLine("Ingrese los numeros positivos que desee calcular el promedio, para finalizar ingrese un 0 ");
        double suma = 0;
        double contador = 0;
        double numero = 1;
        while (numero != 0) //el programa se ejecuta mientras el numero ingresado sea distinto de 0
        {
            if (double.TryParse(Console.ReadLine()?.Replace(",", "."), out numero)) //en este if se verifica que ingrese un numero y no una cadena de texto, uso double para que lea los numeros con coma
            {
                if (numero >= 0) //este if es para que el usuario no pueda ingresar valores negativos
                {
                    suma += numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("entrada invalida, ingrese un numero positivo");
                    numero = 1;
                }
            }
            else
            {
                Console.WriteLine("entrada invalida, ingrese un numero ");
                numero = 1;

            }

        }
        double promedio = suma / contador;
        Console.WriteLine($"el promedio de los valores ingresados es: {promedio}");
    }
}

*/

// Ejercicio 3 El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos; el sistema informará cuántos nombres de han ingresado.

using static System.Runtime.InteropServices.JavaScript.JSType;
/*
class Program
{
    static void Main(string[] Args)
    {
        Console.WriteLine("Ingrese los nombres que desea sumar, para cortar ponga un nombre vacío ");
        
        string nombres = "l";
        int contador = 0;

        while (!string.IsNullOrWhiteSpace(nombres))
        {
            Console.WriteLine("Ingrese nombre ");
            nombres = Console.ReadLine();
            if (double.TryParse(nombres, out _))
            {
                Console.WriteLine("ingrese un dato valido ");
                contador--;
            }
            else
            {
                contador++;
            }
        }
        Console.WriteLine($"la cantidad de nombres ingresados es {contador}");
    }
}
*/


//Ejercicio 4 