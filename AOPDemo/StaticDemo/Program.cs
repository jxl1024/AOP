using StaticDemo.Model;
using StaticDemo.Services;
using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 装饰器模式
            //// 实例化对象
            //IAccountService accountService = new AccountService();
            //// 实例化装饰器类，并用上面的实例给构造方法传值
            //var account = new AccountDecorator(accountService);
            //var user = new User { Name = "Rick", Password = "12345678" };
            //// 调用装饰器类的注册方法，相当于调用实例化对象的注册方法
            //account.Reg(user);
            #endregion

            #region 代理模式
            var account = new ProxyAccount();
            var user = new User { Name = "Tom", Password = "12345678" };
            account.Reg(user);
            #endregion

            Console.ReadKey();
        }
    }
}
