using System;

namespace PostSharpDemo
{
    /// <summary>
    /// 订单业务类
    /// </summary>
    public class OrderBusiness
    {
        [Log(ActionName ="DoWork")]
        public void DoWork()
        {
            // 记录日志
            // LgoHelper.RecoreLog("执行业务前");
            Console.WriteLine("执行订单业务");
            // LgoHelper.RecoreLog("执行业务后");
        }
    }
}
