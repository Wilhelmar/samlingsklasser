using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samlingsklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Övning 1

            //Skapa en dictionary med int som nyckel och int som värde
            SortedList<int, int> resultat = new SortedList<int, int>();

            //skapa ett Random objekt för att slumpa
            Random random = new Random();

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);

                //Öka förekomsten av tal
                resultat[tal]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

            //Det är samma sak som den innan fast den är sorterad vilket gör att det tar längre tid att använda.

            Console.ReadLine();
           */
            //Övning 2

            Console.WriteLine("Övning 2");
            bool stop = true;
            List<double> lista = new List<double>();
            int i = 0;
            do
            {
                
                Console.Write("Mata in ett tal: ");
                double tal = double.Parse(Console.ReadLine());
                lista.Add(tal);
            } while (!lista.Contains(0));

            
            


        }
    }
}
