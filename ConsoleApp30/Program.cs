using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApp30
{
    class Program
    {

        static void Main(string[] args)
        {
                        
            Console.WriteLine("До потаскухи");
            Task<string> a = DelayOperationAsync("a",100);
            Task<string> b = DelayOperationAsync("b",100);
            Console.WriteLine("За потаскухой");
            Console.WriteLine(a.Result);
            Console.WriteLine(b.Result);
            Console.WriteLine("Закончили");
            Console.ReadKey();
        }

        public static async Task<string> DelayOperationAsync(string s, int timeDelay) // асинхронный метод
        {
            Task<string> t = Task.Run(()=>B(s, timeDelay));
            return await t;
        }

        static string B(string msg,int timeDelay)
        {
            string s = "";
            Console.WriteLine($"Начало {msg}");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(msg);
                s += $"[{msg}]";
                Thread.Sleep(timeDelay);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine($"Завершение  {msg}");
            s = $"РЕЗУЛЬТАТ РАБОТЫ АСИНХРОНКИ: " + s;
            return s;
        }



    }
}
