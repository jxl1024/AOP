using StaticDemo.Model;
using System;

namespace StaticDemo.Services
{
    /// <summary>
    /// 实现IAccountService接口
    /// </summary>
    public class AccountService : IAccountService
    {
        public void Reg(User user)
        {
            // 业务代码 之前 或者之后执行一些其它的逻辑
            Console.WriteLine($"{user.Name}注册成功");
        }
    }
}
