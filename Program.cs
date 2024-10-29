static void AddTask()
{
    Console.Write("Введите описание задачи: ");
    string taskDescription = Console.ReadLine();
    tasks.Add(taskDescription);
    Console.WriteLine("Задача добавлена.");
}

