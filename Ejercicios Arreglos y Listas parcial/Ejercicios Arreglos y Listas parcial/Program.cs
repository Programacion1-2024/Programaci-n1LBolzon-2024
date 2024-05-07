// See https://aka.ms/new-console-template for more information
//Ejercicio 1: Ordenar palabras alfabéticamente El usuario ingresará una lista de palabras. El programa debe guardar, ordenar estas
//palabras alfabéticamente y mostrarlas en la consola.
/*
class Program
{
    static void Main(string[] args)
    {
        List<string> palabras = new List<string>();
        string? palabra = "a"; //se coloca el signo ? para que el for pueda leer un valor nulo
        Console.WriteLine("Ingrese las palabras que desee ordenar alfabeticamente, para frenar ingrese 0 ");
        do
        {
            Console.WriteLine("ingrese las palabras ");
            palabra = Console.ReadLine();
            if (palabra != null)
            {
                palabras.Add(palabra);
            }
        }
        while (!string.IsNullOrEmpty(palabra));
        palabras.Sort();
        Console.WriteLine("El orden de las palabras es: ");
            foreach (string p in palabras)
            {
            Console.WriteLine(p);
            }
        
    }
}
*/
//Ejercicio 2: Filtrar números pares en una lista El usuario ingresará números enteros uno por uno. El programa debe solicitar al usuario que ingrese los números hasta que ingrese el número 0 para finalizar. Luego, debe mostrar los
//números ingresados de mayor a menor en la consola. Si se ingresa un valor no válido, se mostrará un mensaje de error.