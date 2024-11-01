
static void EditTask()
        {
            ViewTasks(); // Показать текущие задачи перед редактированием
            Console.Write("Введите номер задачи для редактирования: ");

using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            ShowMenu(); // Вызов меню
        }

        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Добавить задачу");
                Console.WriteLine("2. Удалить задачу");
                Console.WriteLine("3. Просмотреть задачи");
                Console.WriteLine("4. Редактировать задачу");
                Console.WriteLine("5. Выйти");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        ViewTasks();
                        break;
                    case "4":
                        EditTask();
                        break;
                    case "5":
                        return; // Выход из программы
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Введите описание задачи: ");
            string taskDescription = Console.ReadLine();
            tasks.Add(taskDescription);
            Console.WriteLine("Задача добавлена.");
        }

        static void RemoveTask()
        {
            ViewTasks(); // Показать текущие задачи перед удалением
            Console.Write("Введите номер задачи для удаления: ");

            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                Console.Write("Введите новое описание задачи: ");
                string newDescription = Console.ReadLine();
                tasks[taskNumber - 1] = newDescription;
                Console.WriteLine("Задача обновлена.");
            }
            else
            {
                Console.WriteLine("Неверный номер задачи.");
            }
        }

}
        static void ViewTasks()
        {
            Console.WriteLine("Список задач:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("Нет задач для отображения.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }
}
