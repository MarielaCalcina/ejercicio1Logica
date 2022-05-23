using System;
using System.Collections.Generic;

namespace ejercicio1Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Hola mundo! !!!";

            char[] fraseLista = frase.ToCharArray();
            string fraseAlReves = string.Empty;
            //recorrer cada palabara

            for (int i = 0; i < frase.Length; i++)
            {
                fraseAlReves += fraseLista[frase.Length - (i + 1)];
            }

            Console.Write(fraseAlReves);
        }
    }
}
