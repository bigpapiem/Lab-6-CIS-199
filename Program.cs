using System;//S0287, Lab 6, 3/21/2020, CIS 199-02, lab creates triangles in a pattern through use of loops and *'s
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10;//Establishes constant int of MAX_ROWS which equals 10
            //Pattern A work
            Console.WriteLine("Pattern A");
            for (int i = 1; i <= MAX_ROWS; i++)//Outer loop for pattern A
            {
                for (int j = 1; j <= i; j++)//Inner loop for pattern A
                {
                    Console.WriteLine("*");//Writes *'s for pattern
                }
                Console.WriteLine();
            }
            //Pattern B work
            Console.WriteLine("Pattern B");
            for (int i = MAX_ROWS; i >= 1; i--)//Outer loop for pattern B
            {
                for (int j = 1; j <= i; j++)//Inner loop for pattern B
                {
                    Console.Write("*");//Writes *'s for pattern
                }
                Console.WriteLine();
            }
                    //Pattern C work
                    Console.WriteLine("Pattern C");
                    for (int i = 1; i <= MAX_ROWS; i++)//Outer loop for rows 
                    {
                        for (int k = i; k > 1; k--)//Inner loop for spaces 
                        {
                            Console.Write(" ");//Prints spaces
                        }
                        for (int j = MAX_ROWS; j > i; j--)//Inner loop for *'s
                        {
                            Console.Write("*");//Writes *'s for pattern
                }
                        Console.WriteLine();
                    }
                    // for pattern D work
                    Console.WriteLine("Pattern D");
                    for (int i = 1; i <= MAX_ROWS; i++)//Outer loop for rows
            {
                        for (int k = MAX_ROWS -1; k >= i; k--)//Inner loop for spaces 
                {
                            Console.Write(" ");//Prints spaces
                        }

                        for (int j = 1; j <= i; j++)//Inner loop for *'s
                {
                            Console.Write("*");//Writes *'s for pattern
                        }
                        Console.WriteLine();
                    }
            Console.ReadKey();//Reads given key of patterns 
                }
            }
        }
    

