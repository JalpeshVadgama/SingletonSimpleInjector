﻿using System;

namespace SimpleInjectorSingleTonExample
{
    class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}