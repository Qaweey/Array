using System;

namespace Arrayassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the first positve integer size ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second positive integer size ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the third positive integer size");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the forth positive integer size ");
                int d = int.Parse(Console.ReadLine());
                if (c != d)
                {
                    Console.WriteLine("Error:The third and forth size must be the same to calculate determinant and square correctly");
                }

                else
                {
                    int[,,,] myarray = new int[a, b, c, d];
                    // Reading the array to the console
                    for (int i = 0; i < a; i++)
                    {
                        for (int j = 0; j < b; j++)
                        {
                            for (int k = 0; k < c; k++)
                            {
                                for (int l = 0; l < d; l++)
                                {
                                    Console.WriteLine("PLease enter matrix[{0},{1},{2},{3}]", i, j, k, l);
                                    myarray[i, j, k, l] = int.Parse(Console.ReadLine());
                                }
                            }
                        }

                    }
                    // Displaying the array to the console
                    int det1 = 0;


                    Console.WriteLine();
                    Console.WriteLine("The matrices formed are displayed below");
                    for (int i = 0; i < myarray.GetLength(0); i++)
                    {
                        for (int j = 0; j < myarray.GetLength(1); j++)
                        {
                            for (int k = 0; k < myarray.GetLength(2); k++)
                            {

                                for (int l = 0; l < myarray.GetLength(3); l++)
                                {

                                    Console.Write(myarray[i, j, k, l] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                    // Calculating determinant: Using Crammers Rule





                    for (int k = 0; k < c; k++)
                    {
                        det1 += myarray[0, 0, 0, k] * (myarray[0, 0, 1, (k + 1) % 3] * myarray[0, 0, 2, (k + 2) % 3] - myarray[0, 0, 1, (k + 2) % 3] * myarray[0, 0, 2, (k + 1) % 3]);

                    }
                    Console.WriteLine($"If the matrices generated are the same determinant is {det1 * a * b} ");




                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
