using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrimeNumber
{
    public class Program
    {
        
    static bool Prime(int num)
        {
            if (num== 1)
                    return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    static void Main(string[] args)
        {
            string minstr,maxstr;
            int min, max;
            Console.WriteLine("欢迎来到素数陈列函数\n");
            Console.WriteLine("输入下限\n");
            minstr=Console.ReadLine();

            Console.WriteLine("输入上限\n");
            maxstr = Console.ReadLine();

            min = Int32.Parse(minstr);
            max = Int32.Parse(maxstr);
            int count = 0;
            for (int i=min;i<=max;i++)
            {
                if(Prime(i))
                {
                    Console.Write(i);
                    Console.Write(" ");
                    count++;
                    if(count%10==0)
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
