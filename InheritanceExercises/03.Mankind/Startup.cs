﻿using System;
using System.Linq;

namespace _03.Mankind
{
    public class Startup
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine()
                       .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                       .ToList();

                var workerInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]),
                    decimal.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
