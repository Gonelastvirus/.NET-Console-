using System;

namespace array
{
    public class Program
    {
        public int sort(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine("\n Sorted Array:\n");
            foreach (int i in arr)
            {
                Console.WriteLine(i+" ");
            }
            return 0;
        }

        public static void Main(String[] args)
        {
            Program obj = new Program();
            Console.WriteLine("How many number you wanna sort?(max20)");
            int n=Convert.ToInt32(Console.ReadLine());
            int [] num=new int[n];//Fixed Array
            for (int i=0; i<n; i++){
                Console.WriteLine("Enter the "+(i+1)+" Element");
                int x=Convert.ToInt32(Console.ReadLine());
                num[i]=x;
            }
            obj.sort(num);
        }
    }
}
