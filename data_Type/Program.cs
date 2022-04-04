using System;

namespace data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'G';

           
            int i = 89;

            short s = 56;

           

           
            long l = 4564;

           
            uint ui = 95;

            ushort us = 76;
           
            
            ulong ul = 3624573;

            
            double d = 8.358674532;

            
            float f = 3.7330645f;

            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
	}
    
using System;
namespace Pk
	{

		class MK
		{

			public static void Main()
			{

				int[] intArray;

				intArray = new int[5];
				intArray[0] = 10;
				intArray[1] = 20;

				// so on...
				intArray[2] = 30;
				intArray[3] = 40;
				intArray[4] = 50;

				Console.Write("For loop :");
				for (int i = 0; i < intArray.Length; i++)
					Console.Write(" " + intArray[i]);

				Console.WriteLine("");
				Console.Write("For-each loop :");

				foreach (int i in intArray)
					Console.Write(" " + i);

				Console.WriteLine("");
				Console.Write("while loop :");

				int j = 0;
				while (j < intArray.Length)
				{
					Console.Write(" " + intArray[j]);
					j++;
				}

				Console.WriteLine("");
				Console.Write("Do-while loop :");

				int k = 0;
				do
				{
					Console.Write(" " + intArray[k]);
					k++;
				} while (k < intArray.Length);
			}
        }
		using System;
        namespace PK1
        {

            class Pkk
            {
                public static void Main()
                {

                    int[,] intarray = new int[,] { { 1, 2 },
                                         { 3, 4 },
                                         { 5, 6 },
                                         { 7, 8 } };
.
                    int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
                                             { 5, 6 }, { 7, 8 } };

                    string[,] str = new string[4, 2] { { "one", "two" },
                                            { "three", "four" },
                                            { "five", "six" },
                                            { "seven", "eight" } };

                    int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
                                             { 4, 5, 6 } },
                                             { { 7, 8, 9 },
                                           { 10, 11, 12 } } };


                 
                    int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
                                                  { 4, 5, 6 } },
                                                  { { 7, 8, 9 },
                                                { 10, 11, 12 } } };

                    
                    Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
                    Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
                    Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
                    Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

                    Console.WriteLine("2DArray[1][1] (other) : "
                                             + intarray_d[1, 1]);

                    Console.WriteLine("2DArray[1][0] (other)"
                                         + intarray_d[1, 0]);

                    Console.WriteLine("3DArray[1][0][1] : "
                                       + intarray3D[1, 0, 1]);

                    Console.WriteLine("3DArray[1][1][2] : "
                                      + intarray3D[1, 1, 2]);

                    Console.WriteLine("3DArray[0][1][1] (other): "
                                         + intarray3Dd[0, 1, 1]);

                    Console.WriteLine("3DArray[1][0][2] (other): "
                                         + intarray3Dd[1, 0, 2]);

                    Console.WriteLine("To String element");
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 2; j++)
                            Console.Write(str[i, j] + " ");
                }
            }
        }

    }

