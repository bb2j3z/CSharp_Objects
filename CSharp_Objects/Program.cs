using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Objects
{

    public static class MathHelpers
    {
        public static int[][] BuildMultiplicationTable(int maxFactor)
        {
            int[][] temptable = new int[maxFactor + 1][];

            // populate jagged array
            for (int rowIndex = 0; rowIndex < maxFactor + 1; rowIndex++)
            {
                temptable[rowIndex] = new int[maxFactor + 1];

                for (int colIndex = 0; colIndex < maxFactor + 1; colIndex++)
                {
                    temptable[rowIndex][colIndex] = rowIndex * colIndex;
                }

            }


            return temptable;
        }
    }

    class Cell
    {
        public string Contents { get; set; }
    }

    class Program
    {

        public static void Arrays()
        {
            // Different Methods for initializing array
            // Method: 1
            // int[] lockCombination = new int[3];
            // Method 2
            // int[] lockCombination = new int[3] { 10, 5, 32 };
            // Shortcut
            //int[] lockCombination = new[] { 10, 5, 32 };
            int[] lockCombination = { 10, 5, 32 };
            int last = lockCombination[2];
        }

        public static void JaggedArrays()
        {

            Cell[][] sheet = new Cell[100][];
            sheet[0] = new Cell[10];

            for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            {
                sheet[rowIndex] = new Cell[10];
                for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
                {
                    sheet[rowIndex][colIndex] = new Cell();
                }
            }

            foreach (Cell[] row in sheet)
            {
                foreach (Cell cell in row)
                {
                    Console.Write(cell);
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            // Arrays();
            // JaggedArrays();

            Console.ReadKey();

        }
    }
}
