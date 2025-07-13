using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    internal interface IUploadTask
    {
        (string title, string info) Upload(int taskId);
    }
}
