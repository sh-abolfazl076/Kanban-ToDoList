using Kanban_ToDoList.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kanban_ToDoList
{
    public partial class EditTaskForm : Form
    {
        Messages massage = new Messages();
        EditTask edit = new EditTask();
        private int taskId ;

        public EditTaskForm(int taskId)
        {
            InitializeComponent();
            this.taskId = taskId;
        }

        /// <summary>
        /// Saves changes to SQL when Edit button is clicked.
        /// </summary>
        /// <param name="sender">Edit button.</param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // If a stage is selected, edit the task. Else, show error message.
            int selectedIndex = comboBoxEdit.SelectedIndex;
            if (selectedIndex >= 0)
            {
                edit.EditTaskBtn(taskId ,txtEdit.Text , selectedIndex + 1);
            }
            else
            {
                MessageBox.Show(massage.msErrorcomboBox);
            }
        }
    }
}
