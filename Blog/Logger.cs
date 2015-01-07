using Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }
    }
}