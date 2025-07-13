using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_ToDoList
{

    internal class MessagesLog
    {
        public string msStart = "Application started successfully.";
        public string msError = "An error occurred while starting the application.";
        public string msLoad = "MainForm loaded successfully.";
        public string msLoadError = "An error occurred while reloading tasks:";
        public string msEdit = "Edit button clicked for task ID:";
        public string msEditError = "An error occurred while editing the task with ID:"; 
        public string mscreateTask = "Attempting to edit task with ID: ";
        public string msLoadeInfo = "An error occurred while loading tasks.";
        public string UnloaInfo = "Task loading failed";
        public string msCreateloding = "Click a Create Task";
        public string msCreateTask = "Creating a new task with title and info :";
        public string msCreateTaskError = "Error creating task with title and info :";
    }
}
