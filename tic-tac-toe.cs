using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        const int MATRIX_SIZE = 3;
        //y.x
          static  char[,] matrix = new char[MATRIX_SIZE, MATRIX_SIZE] {{' ', ' ', ' '}, {' ', ' ', ' '}, {' ', ' ', ' '}};
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
        
        static void Main(string[] args)
        {
          PrintMatriz();
        }
    }
}
    


