using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList.Services
{
    internal class LoadTaskBtns : ILoadTaskBtns
    {
        /// <summary>
        /// Create a button for each row based on its status.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="PanelToDo"></param>
        public void CreateBtn(SqlDataReader reader, FlowLayoutPanel PanelToDo)
        {

            while (reader.Read()) // While there are rows in the database, create a button 
            {
                int id = reader.GetInt32(0); // Get the task ID
                string title = reader.GetString(1); // Get the task title from title btn

                // Create a new button for the task and set properties
                Button btn = new Button();
                btn.Text = title;
                btn.Width = 125;
                btn.Height = 40;
                btn.Tag = id;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.SteelBlue;
                btn.Margin = new Padding(5, 3, 5, 1);

                btn.Click += TaskButton_Click; // click event handler

                PanelToDo.Controls.Add(btn); // Add the button to the FlowLayoutPanel
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Convert sender to Button
            int taskId = (int)btn.Tag; // Get task ID from button

            EditTaskForm editForm = new EditTaskForm(taskId); // Open form EditTaskForm
            editForm.Owner = Application.OpenForms["MainForm"]; // 
            editForm.ShowDialog();
        }

    }
}
