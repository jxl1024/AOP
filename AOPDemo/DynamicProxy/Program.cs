using DynamicProxy.Model;
using DynamicProxy.Services;
using System;

namespace DynamicProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用动态代理工厂类创建动态代理对象，传递AccountService，并且传递两个委托
            var acount = ProxyFactory.Create<AccountService>(before:() =>
            {
                Console.WriteLine("注册之前");
            }, after:() =>
            {
                Console.WriteLine("注册之后");
            });

            User user = new User() 
            {
             Name="张三",
             Password="123456"
            };
            // 调用注册方法
            acount.Reg(user);

            Console.ReadKey();
        }
    }
}
