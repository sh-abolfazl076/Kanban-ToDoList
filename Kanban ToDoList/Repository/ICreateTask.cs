using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_ToDoList
{
    /// <summary>
    /// This class defines the rules and logic for the method CreateTask
    /// </summary>
    internal interface ICreateTask
    {
        void CreateTaskBtn(string title , string info , string Date);
    }
}
