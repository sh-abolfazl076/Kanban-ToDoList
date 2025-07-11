using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    /// <summary>
    /// This class defines the rules and logic for the method ILoadTaskBtns
    /// </summary>
    internal interface ILoadTaskBtns
    {
        void CreateBtn(SqlDataReader reader, FlowLayoutPanel PanelToDo);
        void TaskButton_Click(object sender, EventArgs e);
    }
}
