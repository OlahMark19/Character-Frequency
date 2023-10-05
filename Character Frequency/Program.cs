using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Character_Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the sequence: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the " + n + " characters with space between!");
            string[] tokens = Console.ReadLine().Split(' ');
            string[] characters = new string[n];

            int[] box = new int[n];
            int freq = 1;

            for(int i = 0; i < characters.Length; i++)
            {
                characters[i] = tokens[i];
            }

            for(int i = 0; i < characters.Length; i++)
            {
                
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[j] == characters[i])
                    {
                        freq++;
                    }

                }
                for (int k = i - 1; k > -1; k--)
                {
                    if (characters[k] == characters[i])
                    {
                        freq = 0;
                    }

                }
                box[i] = freq;
                freq = 1;

            }

            int biggest = box[0];
            string chr = characters[0];

            for(int i = 0; i < box.Length; i++)
            {
                if (box[i] > biggest)
                {
                    biggest = box[i];
                    chr = characters[i];
                }
            }
            Console.WriteLine("The most frequent character is " + chr + " which appears " + biggest + " times.");
           
            
            Console.ReadKey();

        }
    }
}
