﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    /// <summary>
    /// This class defines the rules and logic for the method ILoadTasksPanel
    /// </summary>
    internal interface ILoadTasksPanel
    {
        void LoadTasksInfoPanal(FlowLayoutPanel PanelToDo, int StageId);
    }
}
