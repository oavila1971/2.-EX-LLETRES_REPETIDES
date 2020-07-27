using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EX2_Lletres_Repetides
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 1:

            Console.WriteLine("FASE 1:");

            char[] myname;
            myname = new char[5];
            myname[0] = 'O';
            myname[1] = 's';
            myname[2] = 'c';
            myname[3] = 'a';
            myname[4] = 'r';

            for (int i = 0; i < myname.Length; i++)
            {
                Console.WriteLine(myname[i]);

            }

            // FASE 2:

            Console.WriteLine("FASE 2:");

            List<char> myname2 = new List<char> { 'O','s', 'c', 'a', 'r', '2'};
            

            for (int i = 0; i < myname2.Count; i++)
            {
                if ((myname2[i] >= 'A' && myname2[i] <= 'Z') || myname2[i] >= 'a' && myname2[i] <= 'z')
                {
                    if (myname2[i] == 'a' || myname2[i] == 'A' || myname2[i] == 'e' || myname2[i] == 'E' || myname2[i] == 'i'
                        || myname2[i] == 'I' || myname2[i] == 'o' || myname2[i] == 'O' || myname2[i] == 'u' || myname2[i] == 'U')
                    {
                        Console.WriteLine(myname2[i] + " VOCAL");
                    }
                    else
                    {
                        Console.WriteLine(myname2[i] + " CONSONANT");
                    }
                }
                else
                {
                    Console.WriteLine(myname2[i] + " Els noms de persones no contenen números!");
                }

            }

            // FASE 3:

            Console.WriteLine("FASE 3:");

            Dictionary<char, int> comptadorLletres = new Dictionary<char, int>();

            for (int i = 0; i < myname2.Count; i++)
            {
                if (comptadorLletres.ContainsKey(myname2[i]))
                {
                    comptadorLletres[myname2[i]]++;
                }
                else 
                {
                    comptadorLletres.Add(myname2[i],1);
                }
                                 
            }

            foreach (KeyValuePair<char, int> j in comptadorLletres)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    j.Key, j.Value);
            }

            // FASE 4:

            Console.WriteLine("FASE 4:");

            string nom = "Oscar";
            string cognom = "Avila";

            string cadNom = "";


          

            for (int i = 0; i < nom.Length; i++)
            {
                
                
                cadNom =  cadNom + nom.Substring(i, 1) + ",";
                
                
            }

            for (int i = 0; i < cognom.Length; i++)
            {
                if (i == 0)
                {
                    cadNom = cadNom + "   ," + cognom.Substring(i, 1);
                }
                else
                {
                    cadNom = cadNom + "," + cognom.Substring(i, 1);
            
                }
            }
                

            
            

            Console.WriteLine("Nom Complet [ '{0}' ]", cadNom);

            
        }
    }
}
