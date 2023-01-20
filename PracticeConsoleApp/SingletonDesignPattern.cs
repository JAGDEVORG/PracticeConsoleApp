using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp
{
    public sealed class Settings
    {
        private static Settings instance = null;
        private readonly object _lock = new object();
        private Settings() { }
        public static Settings GetInstance
        {
            get
            {
                if (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Settings();
                    }
                    return instance;
                }
            }
        }

        public void print()
        {
            Console.WriteLine("Print Method");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Settings s1 = Settings.GetInstance;
            s1.print();
            Console.WriteLine("Main Method!");
        }
    }
}
