static void ShowMenu()
{
    while (true)
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Добавить задачу");
        Console.WriteLine("2. Удалить задачу");
        Console.WriteLine("3. Просмотреть задачи");
        Console.WriteLine("4. Выйти");
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
                return; // Выход из программы
            default:
                Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                break;
        }
    }
}