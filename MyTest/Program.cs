using System;
using System.Diagnostics;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var m=new MyClass();

            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(m.Methon1(999999999));
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            sw.Start();
            Console.WriteLine(m.Methon2(999999999));
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
    }

    class MyClass
    {
        /// <summary>
        /// 遍历
        /// </summary>
        /// <returns></returns>
        public long Methon1(long max)
        {
            long sum = 0;
            for (long i = 0; i <= max; i++)
            {
                sum += i;
            }
            return sum;
        }

        /// <summary>
        /// 等差数列求和(高斯) 首项加末项乘以项数除以2
        /// </summary>
        /// <returns></returns>
        public long Methon2(long max)
        {
            return (1+max)* max / 2;
        }
    }
}
