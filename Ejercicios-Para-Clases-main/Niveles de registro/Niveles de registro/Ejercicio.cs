namespace Niveles_de_registro
{

    /*
        Consigna: 
            En este ejercicio procesará líneas de registro.

            Cada línea de registro es una cadena con el siguiente formato: "[<LEVEL>]: <MESSAGE>".

            Hay tres niveles de registro diferentes:
                INFO
                WARNING
                ERROR

            Tienes tres tareas, cada una de las cuales tomará una línea de registro y te pedirá que hagas algo con ella.

            Tarea 1: Obtener mensaje de una línea de registro
               Implemente el método ( estático ) LogLine.Message() para devolver un mensaje de línea de registro.
                   LogLine.Message("[ERROR]: Invalid operation")
                   // => "Invalid operation"

            Tarea 2: Obtener el nivel de registro de una línea de registro
               Implemente el método ( estático ) LogLine.LogLevel() para devolver el nivel de registro de una línea de registro, que debe devolverse en minúsculas.
                   LogLine.LogLevel("[ERROR]: Invalid operation")
                   // => "error"

            Tarea 3: Reformatear una línea de registro
               Implemente el método ( estático ) LogLine.Reformat() que reformatea la línea de registro, poniendo el mensaje primero y el nivel de registro después entre paréntesis.
                   LogLine.Reformat("[INFO]: Operation completed")
                   // => "Operation completed (info)"

            TIPS: Funciones Split, IndexOf y Substring de la clase String
   */

    static class LogLine
    {
        public static string Message(string logLine)
        {
            string[] arregloLineas = logLine.Split(':'); //hago un arreglo y lo divido en 2 partes con el split para luego usar el segundo valor del arreglo
            
            string segundaLinea = arregloLineas[1];
            string segundaLineaTrim = segundaLinea.Trim(); //el trim para sacar el espacio de la segunda linea del arreglo creado anteriormente
            return segundaLineaTrim;
        }

        public static string LogLevel(string logLine)
        {
            string[] arregloLineas = logLine.Split(':'); //con 1 comilla trabaja caracteres 
            string primeraLinea = arregloLineas[0];
            string primeraLineaLimpia = primeraLinea.Replace("[","").Replace("]",""); //con 2 comillas trabaja strings (reemplazo los corchetes por valor vacio
            string primeraLineaLimpiaMin = primeraLineaLimpia.ToLower(); //paso a minuscula 
            return primeraLineaLimpiaMin;
        }

        public static string Reformat(string logLine)
        {
            string primeraLinea = LogLevel(logLine); //uso funciones para no repetir codigo 
            string segundaLinea = Message(logLine);

            //string[] arregloLineas = logLine.Split(':');
            //string segundaLinea = arregloLineas[1];
            //segundaLinea.Trim();
            //string primeraLinea = arregloLineas[0];
            //primeraLinea.ToLower();
           
            return segundaLinea + " (" + primeraLinea + ")";
           
        }
    }

}
