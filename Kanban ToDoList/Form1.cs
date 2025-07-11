using Kanban_ToDoList.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    public partial class MainForm : Form
    {
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
            CreateTaskForm taskForm = new CreateTaskForm();
            taskForm.ShowDialog();  //Set the form to open centered on the parent window.
        }// End event btnCreateTask_Click


        /// <summary>
        /// Handles the load event of the MainForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTasksPanel panelToDo = new LoadTasksPanel(); // Create an instance .
            panelToDo.LoadTasksInfoPanal(PanelToDo); // Load task information into the "To Do" panel.
        }// End Loading
    }
}
