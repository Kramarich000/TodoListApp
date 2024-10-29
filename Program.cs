static void RemoveTask()
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