using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split(@"\").ToList();

            string lastPath = path[path.Count - 1];
            string[] lastPathSplitted = lastPath.Split('.');
            Console.WriteLine($"File name: {lastPathSplitted[0]}");
            Console.WriteLine($"File extension: {lastPathSplitted[1]}");
        }
    }
}
