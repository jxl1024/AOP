using DynamicProxy.Model;
using System;

namespace DynamicProxy.Services
{
    public class AccountService : MarshalByRefObject, IAccountService
    {
        public void Reg(User user)
        {
            Console.WriteLine($"{user.Name}注册成功");
        }
    }
}
