using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    public partial class CreateTaskForm : Form
    {
        ICreateTask repotaskform;
        private MainForm mainForm;
        public CreateTaskForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// This event is for creating a task in sqlserver
        /// This event creates a new task in SQL server using the provided  title , info and the current date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string info = txtInfo.Text;

            // Get the current date
            DateTime now = DateTime.Now;
            string Date = now.ToString("yyyy/MM/dd");

            // Create and use of the class 
            repotaskform = new CreateTask();
            repotaskform.CreateTaskBtn(title,info,Date);

            // Clear the input 
            txtTitle.Text = "";
            txtInfo.Text = "";

            mainForm?.ReloadTasks(); // Refresh task list in main form

            this.Close(); // Close the form
        }
    }
}
