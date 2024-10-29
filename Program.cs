using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            // Вызов метода меню
        }

        static void AddTask()
        {
            Console.Write("Введите описание задачи: ");
            string taskDescription = Console.ReadLine();
            tasks.Add(taskDescription);
            Console.WriteLine("Задача добавлена.");
        }
    }
}
