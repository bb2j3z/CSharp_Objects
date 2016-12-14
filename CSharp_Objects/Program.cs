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

        public static List<int> GetPowersOf2(int start)
        {
            List<int> temp = new List<int>();

            for(Double i = 0; i <= start; i++)
            {
                temp.Add((int)Math.Pow(2, i));
            }
            return temp;
        }

    }

    class Cell
    {
        public string Contents { get; set; }
    }

    class Program
    {
        public static void Lists()
        {
            //List<string> students = new List<string>(500);
            //Console.Write(students.Count);
            //Console.Write(students.Capacity);
            //students.Add("Mary");
            //students.Add("Brian");

            // List<string> students = new List<string>(5) { "Mary", "Sue", "Allen", "Bill", "Beth" };

            List<string> students = new List<string>() { "Mary", "Sue", "Allen", "Bill", "Beth" };
            List<string> students2 = new List<string>(students);

            string[] studentArray = students.ToArray();

            foreach(string student in students)
            {


            }

            students.Add("Frank");

            students.Remove("Beth");


        }
       
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

            List<int> array = MathHelpers.GetPowersOf2(4);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
           
            Console.ReadKey();

        }
    }
}
