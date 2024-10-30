static void EditTask()
        {
            ViewTasks(); // Показать текущие задачи перед редактированием
            Console.Write("Введите номер задачи для редактирования: ");
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