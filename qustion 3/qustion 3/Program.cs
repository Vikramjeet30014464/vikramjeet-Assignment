//Name: Vikramjeet Singh
//Student ID: 30014464
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qustion_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            Random rand = new Random();  //created Random class object


            int[,] matrixA = new int[3, 3];
            int[,] matrixB = new int[3, 3];
            int[,] matrixC = new int[3, 3];


            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    matrixA[i, j] = rand.Next(-10, 10);
                    matrixB[i, j] = rand.Next(-10, 10);
                }

            }

            /*For Loop to Display  Matrix A */
            Console.Write("\nRandom 3x3 Matrix A:\n");
            for (i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write("\t{0}", matrixA[i, j]);
                }

            }

            /*For Loop to Display  Matrix B */
            Console.Write("\n\nRandom 3x3 Matrix B:\n");
            for (i = 0; i < matrixA.GetLength(0); i++)
            {
                Console.Write("\n");
                for (j = 0; j < matrixA.GetLength(1); j++)
                {
                    Console.Write("\t{0}", matrixB[i, j]);
                }

            }

            /*For Loop to  ADD C=A+B Matrices  */
            for (i = 0; i < matrixC.GetLength(0); i++)
            {
                for (j = 0; j < matrixC.GetLength(1); j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }


            /*Display Result of  two added matrices(C=A+B):*/
            Console.Write("\n\nAddition Result of  two matrices C=A+B: \n");
            for (i = 0; i < matrixC.GetLength(0); i++)  // row
            {
                Console.Write("\n");
                for (j = 0; j < matrixC.GetLength(1); j++) //cloum
                {
                    Console.Write("\t{0}", matrixC[i, j]);
                }

            }


            Console.ReadLine();
        }
    }
}
