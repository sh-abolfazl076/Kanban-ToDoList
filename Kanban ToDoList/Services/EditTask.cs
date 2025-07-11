using Kanban_ToDoList.Constant;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kanban_ToDoList
{
    internal class EditTask:IEditTask
    {
        /// <summary>
        /// Updates task title and stage in the database.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="txtEdit"></param>
        /// <param name="selectedIndex"></param>
        public void EditTaskBtn(int taskId , string txtEdit , int selectedIndex)
        {
            Messages massage = new Messages();
            Query query = new Query();
            SqlConnection connection = new SqlConnection(query.connection); // Create a new SQL connetion 

            try
            {

                string queryUpdateTask = query.queryUpdateTask + "'" + txtEdit + "'" + ", stageID ="+ selectedIndex+ " where ID =" + taskId;  // query to update task title and stage ID based on task ID
                SqlCommand cmd = new SqlCommand(queryUpdateTask, connection); // Create a SQL command using the query and the database connetion

                connection.Open();

                // Add parameters to the SQL

                cmd.ExecuteNonQuery(); // Execute the query

                MessageBox.Show(massage.msSucessEdit, massage.Sucess, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(massage.msUnSucess, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // The database connection should be closed after it is opened
            }

        } // End Method EditTaskBtn



    }
}
