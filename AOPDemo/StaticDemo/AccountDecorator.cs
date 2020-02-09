using StaticDemo.Model;
using StaticDemo.Services;
using System;

namespace StaticDemo
{
    /// <summary>
    /// 装饰器类
    /// </summary>
    public class AccountDecorator : IAccountService
    {
        private readonly IAccountService _accountService;

        public AccountDecorator(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public void Reg(User user)
        {
            Before();
            // 这里调用注册的方法，原有类里面的逻辑不会改变
            // 在逻辑前面和后面分别添加其他逻辑
            _accountService.Reg(user);
            After();
        }

        private void Before()
        {
            Console.WriteLine("注册之前的逻辑");
        }

        private void After()
        {
            Console.WriteLine("注册之后的逻辑");
        }
    }
}
