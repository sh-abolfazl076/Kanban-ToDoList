using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_ToDoList
{
    internal interface IEditTask
    {
        void EditTaskBtn(int taskId, string txtEdit, int selectedIndex);
    }
}
