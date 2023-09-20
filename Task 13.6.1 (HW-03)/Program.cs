using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstStopWatch = Stopwatch.StartNew();
            List<char> characters1 = new List<char>(File.ReadAllText("C:\\Users\\dsank\\Desktop\\Text1.txt").ToCharArray());
            Console.WriteLine($"Создан List<T>. Время создания: {firstStopWatch.Elapsed.TotalMilliseconds}  мс");

            var secondStopWatch = Stopwatch.StartNew();
            LinkedList<char> characters2 = new LinkedList<char>(File.ReadAllText("C:\\Users\\dsank\\Desktop\\Text1.txt").ToCharArray());
            Console.WriteLine($"Создан LinkedList<T>. Время создания: {secondStopWatch.Elapsed.TotalMilliseconds}  мс");
            Console.WriteLine();            
        }
    }
}