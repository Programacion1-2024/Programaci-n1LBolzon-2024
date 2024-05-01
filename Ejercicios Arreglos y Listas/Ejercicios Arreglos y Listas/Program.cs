// See https:aka.ms/new-console-template for more information

//EjerciciosArreglos
//Ejercicio 1: Ingresar datos en un arreglo y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos números en un arreglo y luego mostrarlos en la consola.
/*
class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5];
        Console.WriteLine("Ingrese los 5 numeros que desea almacenar");
        for (int i = 0; i < numeros.Length; i++)     //for para recorrer el arreglo y luego ir almacenando los valores 
        {
            Console.WriteLine($"ingrese el valor {i} ");
            if (int.TryParse(Console.ReadLine()?.Replace(",", "."), out int numero))
            {
               
                numeros[i] = numero;
            }
            else
            {
                
                Console.WriteLine("ingrese un numero valido ");
                i--;
            }
        }
        Console.WriteLine($"los numemros de la lista son: ");
        for (int i = 0;i < numeros.Length; i++)      //Uso un for para poder recorrer los valores del arreglo y mostrarlos en pantalla ya que poniendo solamente numeros[i] no se puede
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
*/
//Ejercicio 2: Calcular promedio de notas utilizando un arreglo
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas notas y mostrarlo en la consola. Utiliza un arreglo para almacenar las notas.

/*
class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[5];
        double contador = 0;
        double suma = 0;
        Console.WriteLine("Ingrese los 5 numeros para calcular su promedio");
        for (double i = 0; i < numeros.Length; i++)     //for para recorrer el arreglo y luego ir almacenando los valores 
        {
            Console.WriteLine($"ingrese el valor {i} ");
            if (double.TryParse(Console.ReadLine()?.Replace(",", "."), out double numero)) //verifico que ingrese un valor numerico y no un string, ademas de reemplazar los puntos y comas para que pueda interpretar realmente los numeros con coma
            {

                numeros[(int)(double)i] = numero;
                suma += numero;                     
                contador++;
            }
            else
            {

                Console.WriteLine("ingrese un numero valido ");
                i--;
                contador--;
            }
        }
        double promedio = suma / contador;
        Console.WriteLine($"el promedio de los numeros ingresados son: {promedio} y"); //muestro por pantalla el promedio de los nums ingresados
        Console.WriteLine($"los numeros del arreglo son: ");
        for (double i = 0; i < numeros.Length; i++)      //Muestro todos los valores del arreglo para corroborar que se hayan guardado correctamente(no se pide en el ejercicio)
        {
            Console.WriteLine(numeros[(int)(double)i]); //consultar en clase por el (int)(double)i
        }
    }
}
*/
//EjerciciosListas
//Ejercicio 3: Ingresar datos en una lista y mostrarlos
//Consigna: El usuario debe ingresar 5 números enteros. El programa debe almacenar estos números en una lista y luego mostrarlos en la consola.
/*
class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Ingrese los 5 numeros que desea almacenar");
        for (int i = 0; i < 5; i++)     //for para recorrer la lista y luego ir almacenando los valores 
        {
            Console.WriteLine($"ingrese el valor{i + 1} ");
            if (int.TryParse(Console.ReadLine()?.Replace(",", "."), out int numero))
            {

                numeros.Add(numero);  //si la condicion se cumple que agregue el valor ingresado a la lista
            }
            else
            {

                Console.WriteLine("ingrese un numero valido ");
                i--;
            }
        }
        Console.WriteLine($"los numemros de la lista son: ");
        foreach (int i in numeros)     //Uso un for para poder recorrer los valores de la lista y mostrarlos en pantalla ya que poniendo solamente numeros[i] no se puede
        {
            Console.WriteLine(i);
        }
    }
}
*/

//Ejercicio 4: Calcular promedio de notas utilizando una lista
//Consigna: El usuario debe ingresar 5 notas. El programa debe calcular el promedio de estas notas y mostrarlo en la consola. Utiliza una lista para almacenar las notas.
