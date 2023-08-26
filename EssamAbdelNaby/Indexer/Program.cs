using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sd = new Sudoko();
            sd[0,0] = 1;
            sd[0, 1] = 3;
            sd[0, 2] = 4;
            sd[0, 3] = 5;

            sd.display();

            Console.ReadKey();
        }
    }

    public class Sudoko
    {
        private int[,] arr;

        //Constractor
        public Sudoko()
        {
            arr = new int[9, 9];
        }

        //indexer
        public int this[int row, int col]
        {
            get { return arr[row, col]; }

            set
            {
                arr[row, col] = value;
            }
        }

        public void display()
        {
            for(int i=0; i<9; i++)
            {
                for(int j=0; j<9; j++)
                    Console.Write(arr[i,j] + " ");
                Console.WriteLine();
            }
        }
    }
}
