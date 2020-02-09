using PostSharp.Aspects;
using System;

namespace PostSharpDemo
{
    [Serializable]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class LogAttribute: OnMethodBoundaryAspect
    {
        public string ActionName { get; set; }
        public override void OnEntry(MethodExecutionArgs eventArgs)
        {
            LgoHelper.RecoreLog(ActionName + "开始执行业务前");
        }

        public override void OnExit(MethodExecutionArgs eventArgs)
        {
            LgoHelper.RecoreLog(ActionName + "业务执行完成后");
        }
    }
}
