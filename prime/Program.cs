using System;

namespace prime
{
   public class Program
    {
        public int check(int a)
        {
            int flag =0;
            if (a == 0 || a== 1)
            {
            flag = 1;
            }

            for (int i=2; i<=a/2; i++){
                if (a%i==0){
                    flag =1;
                    break;
                }
            }
            return flag;

        }
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int x =Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            int s=obj.check(x);
            Console.WriteLine(s);
             if (s == 0){
                Console.WriteLine("prime");
            }
            else{
                Console.WriteLine("Not Prime");
            }
        }
    
    }
}
