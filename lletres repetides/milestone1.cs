using System;
using System.Collections.Generic;
using System.Text;

namespace lletres_repetides
{
    class milestone1
    {
        public static void Char()
        {
            char[] lletres = { 'd', 'a', 'n', 'i', 'e', 'l' };
            List<char> lista = new List<char>(lletres.Length);
            int i;

            for (i = 0; i < lletres.Length; i++)
            {
                Console.Write(lletres[i]);
            }
            foreach (char l in lista)
            {
                if (l.Equals('a') || l.Equals('e') || l.Equals('i') || l.Equals('o') || l.Equals('u'))
                {
                    Console.WriteLine("vocal");
                }
                else
                {
                    Console.WriteLine("Consonant");
                }
                if (l.Equals('1') || l.Equals('2') || l.Equals('3') || l.Equals('4') || l.Equals('5') || (l.Equals('6') || l.Equals('7') || l.Equals('8') || l.Equals('9') || l.Equals('0')))
                {
                    Console.WriteLine("no numeros pls");
                }
                Dictionary<char, int> numero_letras = new Dictionary<char, int>();
                numero_letras.Add('E', 0);
                foreach (char letra in lista)
                {
                    if (numero_letras.ContainsKey(letra))
                    {
                        numero_letras[letra]++;
                    }
                    else
                    {
                        numero_letras.Add(letra, 1);
                    }
                }

                foreach (KeyValuePair<char, int> result in numero_letras)
                {
                    Console.WriteLine(result.Key + " " + result.Value);
                }
              
            }
        }
    }
}
