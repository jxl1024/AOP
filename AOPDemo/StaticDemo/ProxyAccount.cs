using StaticDemo.Model;
using StaticDemo.Services;
using System;

namespace StaticDemo
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxyAccount : IAccountService
    {
        private readonly IAccountService _accountService;

        /// <summary>
        /// 构造函数没有参数
        /// 直接在里面创建了AccountService类
        /// </summary>
        public ProxyAccount()
        {
            _accountService = new AccountService();
        }

        public void Reg(User user)
        {
            before();
            _accountService.Reg(user);
            after();
        }

        private void before()
        {
            Console.WriteLine("代理：注册之前的逻辑");
        }

        private void after()
        {
            Console.WriteLine("代理：注册之后的逻辑");
        }
    }
}
