﻿namespace Pangrama
{
    /*
    Consigna: 
    Trabajas para una empresa que vende fuentes a través de su sitio web. Les gustaría mostrar una oración diferente cada vez que alguien vea una fuente en su sitio web. Para dar una idea completa de la fuente, las oraciones aleatorias deben usar todas las letras del alfabeto inglés.

    Están organizando un concurso para recibir sugerencias de frases que puedan utilizar. Usted está a cargo de verificar los envíos para ver si son válidos.

    Tu tarea es descubrir si una oración es un pangrama.

    Un pangrama es una oración que utiliza cada letra del alfabeto al menos una vez. No distingue entre mayúsculas y minúsculas, por lo que no importa si una letra está en minúscula (por ejemplo k) o en mayúscula (por ejemplo K).

    Para este ejercicio, una oración es un pangrama si contiene cada una de las 26 letras del alfabeto inglés.

         TIPS: Funciones ToCharArray y Contains de la clase String
   */

    public static class Pangram
    {
        public static bool IsPangram(string input)
        {
            string oracionLimpia = input.ToLower().Replace(" ", "");   //paso la oración a minuscula y reemplazo los espacios en blanco por nada 

            char[] arreglo;
            arreglo = oracionLimpia.ToCharArray();    //paso la subcadena de la oracion a un arreglo de caracteres

            for (char letra = 'a'; letra <= 'z'; letra++) //for para verificar que la oracion tenga todas las letras del alfabeto
            {
                if (!arreglo.Contains(letra))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
