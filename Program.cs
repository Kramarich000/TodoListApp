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
