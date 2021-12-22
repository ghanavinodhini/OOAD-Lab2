using System;
using OO_Lab2RefactorCode.Interfaces;

namespace OO_Lab2RefactorCode
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
