using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;

namespace DynamicProxy
{
    public class DynamicProxy<T> : RealProxy
    {
        private readonly T _target;

        // 执行之前
        public Action BeforeAction { get; set; }

        // 执行之后
        public Action AfterAction { get; set; }

        // 被代理泛型类
        public DynamicProxy(T target) : base(typeof(T))
        {
            _target = target;
        }

        // 代理类调用方法
        public override IMessage Invoke(IMessage msg)
        {
            var reqMsg = msg as IMethodCallMessage;
            var target = _target as MarshalByRefObject;

            BeforeAction();
            // 这里才真正去执行代理类里面的方法
            // target表示被代理的对象，reqMsg表示要执行的方法
            var result = RemotingServices.ExecuteMessage(target, reqMsg);
            AfterAction();
            return result;
        }

    }
}
