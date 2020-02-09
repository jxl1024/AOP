using System;
using System.IO;

namespace PostSharpDemo
{
    public class LgoHelper
    {
        public static void RecoreLog(string message)
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory+"\\log.txt";
            using(StreamWriter sw=new StreamWriter(strPath,true))
            {
                sw.WriteLine(message);
                sw.Close();
            }
        }
    }
}
