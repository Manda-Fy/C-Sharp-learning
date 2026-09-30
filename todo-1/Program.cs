using System;
using System.Collections.Generic;

class TaskItem
{
    public string Name { get; set; }
    public string Status { get; set; }

    public TaskItem(string name, string status = "[ ]")
    {
        Name = name;
        Status = status;
    }

    public void AddTask(TaskItem taskToAdd)
    {
        TaskManager tempManager = new TaskManager();
        tempManager.TaskList.Add(taskToAdd);
    }
}
class TaskManager
{
    public List<TaskItem> TaskList = new List<TaskItem>();
}
class Program
{
    static void Main()
    {
        bool stopProgram = false;
        while (stopProgram == false)
        {
            string userChoice = Console.ReadLine() ?? "2";
            if (userChoice == "1")
            {
                Console.WriteLine("App start");
                string inputName = Console.ReadLine() ?? "";
                string inputStatus = Console.ReadLine() ?? "";
                TaskItem newTask = new TaskItem(inputName, inputStatus);
                TaskManager taskManager = new TaskManager();
                taskManager.TaskList.Add(newTask);
                foreach (TaskItem currentTask in taskManager.TaskList)
                {
                    Console.WriteLine($"Nom de la taches : {currentTask.Name}, Status : {currentTask.Status}");
                }
            }

            if (userChoice == "2")
            {
                stopProgram = true;
            }
        }
        Console.WriteLine("App stop");
    }
}