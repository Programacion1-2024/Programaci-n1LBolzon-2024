using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isograma
{
    /*
        Consigna: 
            Determina si una palabra o frase es un isograma.

            Un isograma (también conocido como "palabra sin patrón") es una palabra o frase sin una letra repetida; sin embargo, se permite que aparezcan espacios y guiones varias veces.

            Ejemplos de isogramas:

            lumberjacks
            background
            downstream
            six-year-old

            La palabra isogramas, sin embargo, no es un isograma porque la s se repite.


            TIPS: Funciones ToCharArray, IndexOf y LastIndexOf de la clase String
    */

    public static class Isogram
    {
        public static bool IsIsogram(string word)
        {
            string PalabraIsograma = word.ToLower().Replace(" ", "").Replace("-", "");    //ToLower para pasar todo el string a minuscula, reemplazo los espacios por nada y los guiones por nada

            for (int i = 0; i < PalabraIsograma.Length; i++) //for para recorrer todos los valores del string 
            {
                if (PalabraIsograma.IndexOf(PalabraIsograma[i]) != PalabraIsograma.LastIndexOf(PalabraIsograma[i])) // el indexOf toma el primer valor del string y los compara con los demas para ver cuantos hay, el LastIndexOf toma el ultimo valor y cuenta cuantos tiene, el if verifica que ambos valores sean distintos significa que se repiten
                {
                    return false;
                }
            }
            return true;
        }
    }
}