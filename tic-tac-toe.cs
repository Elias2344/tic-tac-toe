using System;

namespace Tic_Tac_Toe
{
    class Program
    {
      /// <summary>
      /// Matrix length
      /// </summary>
        const int MATRIX_SIZE = 3;
        //y.x
        /// <summary>
        /// Inner matrix array [y, x]
        /// </summary>
        /// <value>Empty matrix</value>
          static  char[,] matrix = new char[MATRIX_SIZE, MATRIX_SIZE] {{' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};
          /// <summary>
          /// Prints matrix.
          /// </summary>
        static void PrintMatriz() {
              for(int y = 0; y < MATRIX_SIZE; y++){
                  string line = "";
                for(int x = 0; x < MATRIX_SIZE; x++){
                    //Interpolate string
                    //Console.WriteLine($"[y, x] = {y}, {x}");
                    line += matrix[y ,x] + "|"; 
                }
                line = line.Substring(0, line.Length -1);
                Console.WriteLine(line);
                Console.WriteLine("------");
            }
        }
        /// <summary>
        /// Adds a value to the matrix in the specified position
        /// </summary>
        /// <param name="value">value to add</param>
        /// <param name="y">y position</param>
        /// <param name="x">x position</param>
        static void AddValue(char value, int y , int x) {
          //Necesitamos y, x
          //Necesitamos el valor a agregar ("X", "O")
          matrix[y, x] = value
        }
        static void Main(string[] args)
        {
          PrintMatriz();
          AddValue('X', 0, 0);
          PrintMatriz();
        }
    }
}
    


 


