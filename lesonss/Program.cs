using System;
using System.Collections;
using MyLib;
using MyLibraryGenerics;
using static MyLib.TrainingСlass;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

namespace lesonss
{
    class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var outer = Task.Factory.StartNew(() =>      // внешняя задача
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() =>  // вложенная задача
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished.");
                });
            });
            outer.Wait(); // ожидаем выполнения внешней задачи
            Console.WriteLine("End of Main");

            Console.ReadLine();
        }
    }    
}
