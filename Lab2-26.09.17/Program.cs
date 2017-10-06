using System;

namespace Lab2_26._09._17
{
    class ArrayVal
    {
        private int[] arrFirst;
        private int[] arrSecond;
        private int [] sum;
        private int size;

        public int[] ArrFirst { get => arrFirst; set => arrFirst = value; }
        public int[] ArrSecond { get => arrSecond; set => arrSecond = value; }
        public int[] Sum { get => sum; set => sum = value; }

        // private int[] Product;

        public ArrayVal(int size)
        {
            this.size = size; 
            arrFirst = new int[size];
            arrSecond = new int[size];
            sum = new int[size];
        }
        public ArrayVal(int[] a1, int[] a2, int[] s)
        {
            this.arrFirst = a1;
            this.arrSecond = a2;
            this.sum = s;
        }
        //public int CalSum(ref int[] first, ref int[] second)
        public void CalSum()
        {
            for (int i = 0; i < arrFirst.Length; i++)
            {
                arrFirst[i] = int.Parse(Console.ReadLine());
                //b[i] = int.Parse(Console.ReadLine());
                arrSecond[i] = int.Parse(Console.ReadLine());
                sum[i] = arrFirst[i] + arrSecond[i];
            }
            /* for (int j = 0; j < 5;j++)
             {
                 b[j] = int.Parse(Console.ReadLine());
             }*/
            for (int i = 0; i < arrFirst.Length; i++)
            {
                Console.WriteLine("Sum of the two arrays are: {0}", sum[i]);
            }
           // return sum;
        }

        public int[] CalSum(int[] a1, int[] a2)
        {
            int[] s = new int[a1.Length];

            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
                //b[i] = int.Parse(Console.ReadLine());
                a2[i] = int.Parse(Console.ReadLine());
                s[i] = arrFirst[i] + arrSecond[i];
            }
            return s;
        }

        static void Main(string[] args)
        {

           ArrayVal sumCalc = new ArrayVal(3);
           sumCalc.CalSum();

            /*int[] a1 = new int[5];
            int[] a2 = new int[5];
            int[] sum = new int[5];

            ArrayVal sumCalc2 = new ArrayVal(a1,a2,sum);
            

            int[] retrivedSum = sumCalc2.CalSum(new int[5], new int[5]);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Sum of the two arrays are: {0}", retrivedSum[i]);
            }
            */

            /*
            Console.WriteLine("Input five numbers: ");
           // Console.ReadLine();
            Console.WriteLine("Input another five numbers: ");
            //Console.ReadLine();
            CalSum();*/



        }
    }
}
