using Kanban_ToDoList.Services;
using Serilog;
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
        MessagesLog massageLog = new MessagesLog();
        EditTask edit = new EditTask();
        private int taskId ;
        private int selectedIndex;

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
            Log.Information(massageLog.msEdit, taskId);
            try
            {
                Log.Information(massageLog.msEditError, taskId);
                int selectedIndex = comboBoxEdit.SelectedIndex;

                if (IsValidation()) // Review of Validation
                {
                    edit.EditTaskBtn(taskId ,txtEdit.Text , selectedIndex + 1); // // Add 1 to selectedIndex because the value should not start from zero

                    // refresh by calling ReloadTasks.
                    if (this.Owner is MainForm mainForm)
                    {
                        mainForm.ReloadTasks(); 
                    }

                    this.Close(); 
                }
            }
            catch (Exception)
            {

                Log.Error(massageLog.mscreateTask, taskId);             
            }

        } // End btnEdit_Click

        /// <summary>
        /// Loads title and info of a task when the form opens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            Log.Information(massageLog.msLoad, taskId);
            try
            {
                Log.Information(massageLog.msLoadeInfo, taskId);
                UploadTask uploader = new UploadTask();
                (string title , string info) taskUpload = uploader.Upload(taskId); // Sends taskId and gets a (title, info) tuple
                lblTitle.Text = taskUpload.title;
                lblInfo.Text = taskUpload.info; 
            }
            catch (Exception)
            {
                Log.Error(massageLog.msLoadeInfo, taskId);
            }

        } // End EditTaskForm_Load

        /// <summary>
        /// This method is for validation.
        /// </summary>
        /// <returns>Returns true if validation passes, otherwise false</returns>
        private bool IsValidation()
        {
            int selectedIndex = comboBoxEdit.SelectedIndex;
            if (!string.IsNullOrWhiteSpace(txtEdit.Text))
            {
                
                // If the validation result is zero, it means no value exists in the selection
                if (selectedIndex >= 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(massage.msErrorcomboBox, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(massage.msIsvalidation, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;  
            }
        }
    }
}
