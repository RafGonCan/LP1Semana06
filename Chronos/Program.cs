﻿using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            
            crono1.Start();
            Thread.Sleep(500);
            crono2.Start();
            Thread.Sleep(250);
            crono1.Stop();
            crono2.Stop();

            Console.WriteLine("{0:f4}", crono1.ElapsedMilliseconds);
            Console.WriteLine("{0:f4}", crono2.ElapsedMilliseconds);
        }
    }
}
