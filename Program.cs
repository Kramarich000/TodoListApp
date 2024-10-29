
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

static void AddTask()
{

    ViewTasks(); // Показать текущие задачи перед удалением
    Console.Write("Введите номер задачи для удаления: ");
    if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
    {
        tasks.RemoveAt(taskNumber - 1);
        Console.WriteLine("Задача удалена.");
    }
    else
    {
        Console.WriteLine("Неверный номер задачи.");
    }
}

    Console.Write("Введите описание задачи: ");
    string taskDescription = Console.ReadLine();
    tasks.Add(taskDescription);
    Console.WriteLine("Задача добавлена.");
}

