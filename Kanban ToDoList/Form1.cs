using Kanban_ToDoList.Constant;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    public partial class MainForm : Form
    {
        MessagesLog messagesLog = new MessagesLog();
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the CreateTaskForm when the "Create Task" button is clicked.
        /// </summary>
        /// <param name="sender">The button that triggered the event.</param>
        /// <param name="e"> Contains event data.</param>
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            CreateTaskForm taskForm = new CreateTaskForm(this); // Create new task form and pass this form to use later
            taskForm.ShowDialog();  
        }// End event btnCreateTask_Click


        /// <summary>
        /// call Method ReloadTasks
        /// Add Serilog logging before calling ReloadTasks method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            Log.Information(messagesLog.msLoad);
            ReloadTasks();
        }// End MainForm_Load

        /// <summary>
        /// Handles the load event of the MainForm.
        /// </summary>
        public void ReloadTasks()
        {
            try
            {
                LoadTasksPanel panelToDo = new LoadTasksPanel(); 
                panelToDo.LoadTasksInfoPanal(PanelToDo,1); // Load task information into the "To Do" panel.
                panelToDo.LoadTasksInfoPanal(PanelDoing,2); // Load task information into the "PanelDoing" panel.
                panelToDo.LoadTasksInfoPanal(PanelReview,3); // Load task information into the "PanelDoing" panel.
                panelToDo.LoadTasksInfoPanal(PanelDone,4); // Load task information into the "PanelDoing" panel.
                panelToDo.LoadTasksInfoPanal(PanelCanalled,5); // Load task information into the "PanelDoing" panel.

            }
            catch (Exception ex)
            {

                Log.Error(messagesLog.msLoadError, ex.Message);
            }

        }// End Method ReloadTasks
    }
}
