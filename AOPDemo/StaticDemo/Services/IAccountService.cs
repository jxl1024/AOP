using StaticDemo.Model;

namespace StaticDemo.Services
{
    /// <summary>
    /// 接口
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="user"></param>
        void Reg(User user);
    }
}
