using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {

        public static bool KollaPalidrom(string text)
        {
            int min = 0;
            int max = text.Length -1;

            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = text[min];
                char b = text[max];

                //Om det inte är en bokstav eller nummer så hoppar den frammåt en bokstav
                while (!char.IsLetterOrDigit(a))
                {
                    min++;
                    if (min > max)
                        return true;

                    a = text[min];
                }


                //Om det inte är en bokstav eller nummer så hoppar den bakåt en bokstav
                while (!char.IsLetterOrDigit(b))
                {
                    max--;
                    if (min > max)
                        return true;

                    b = text[max];
                }

                //Kollar så att bokstaven i char a är samma bokstav som i char b
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }


        static void Main(string[] args)
        {
            int i = 0;
            string[] palidrom = new string[100];
            while (true)
            {
                Console.WriteLine("Skriv in ett ord som för att se om det är en palindrom");
                Console.WriteLine("Avsluta programmet med en 0: ");
                palidrom[i] = Console.ReadLine();
                if (palidrom[i] == "0")
                {
                    break;
                }
                Console.WriteLine("\n");
                if (KollaPalidrom(palidrom[i]))
                {
                    Console.WriteLine("Ordet är palidrom \n");
                }
                else
                {
                    Console.WriteLine("Ordet är inte en palidrom \n");
                }
                i++;
            }
        }
    }
}
