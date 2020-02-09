using System;

namespace PostSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderBusiness order = new OrderBusiness();
            // 调用方法
            order.DoWork();
            Console.ReadKey();
        }
    }
}
