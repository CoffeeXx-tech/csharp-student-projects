
using System;
using System.Collections.Generic;

public class TaskManager
{
    public static int taskCount=0;
    public static int selection=6;
    public static int Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<string> tasks = new List<string>();
        List<bool> statuses = new List<bool>();
        Console.WriteLine ("Welcome to the Task Management System!");
        while(true)
        {
            ShowMenu();
            switch(selection)
            {
                case 1:
                DisplayTasks(tasks, statuses);
                break;
                case 2: 
                AddTask(tasks, statuses);
                break;
                case 3:
                RemoveTask(tasks, statuses);
                break;
                case 4:
                MarkTaskCompleted(tasks, statuses);
                break;
                case 5:
                return 0;
                break;
                default:
                ShowMenu();
                break;
            }
    }}
    static void ShowMenu()
    {
        Console.WriteLine ("1. Display task list\n2. Add a task\n3. Remove a task\n4. Mark task as completed\n5. Exit program");
        selection = Int32.Parse(Console.ReadLine());
    }
    static void DisplayTasks(List<string> tasks, List<bool> statuses)
    {
        if(taskCount==0)
        {
            Console.WriteLine ("No tasks in the list.");
        }
        else
        {
            Console.WriteLine("Task list:");
            for(int i=0; i<taskCount; i++)
            {
                if(statuses[i]==true)
                {
                Console.WriteLine($"Task {i + 1}: {tasks[i]} (completed)");
                }
                else
                Console.WriteLine($"Task {i + 1}: {tasks[i]}");
            }
        }
    }
    static void AddTask(List<string> tasks, List<bool> statuses)
    {
        Console.WriteLine ("Enter the task description: ");
        tasks.Add(Console.ReadLine());
        statuses.Add(false);
        taskCount++;
    }
    static void RemoveTask(List<string> tasks, List<bool> statuses)
    {
        Console.WriteLine ("Enter the number of the task to remove: ");
        int index = Int32.Parse(Console.ReadLine())-1;
        tasks.RemoveAt(index);
        statuses.RemoveAt(index);
        taskCount--;
    }
    static void MarkTaskCompleted(List<string> tasks, List<bool> statuses)
    {
        Console.WriteLine ("Enter the number of the task to mark as completed: ");
        int index = Int32.Parse(Console.ReadLine())-1;
        statuses[index]=true;
    }
}
