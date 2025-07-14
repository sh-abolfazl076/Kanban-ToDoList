using Kanban_ToDoList.Constant;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    internal class CreateTask : ICreateTask
    {
        /// <summary>
        /// Create a new task with the given title , info and date.
        /// </summary>
        /// <param name="title">the title of the task</param>
        /// <param name="info">datails about the task</param>
        /// <param name="Date">the creation date of the task</param>
        public void CreateTaskBtn(string title, string info , string Date)
        {
            Messages massage = new Messages();
            Query query = new Query();
            SqlConnection connection = new SqlConnection(query.connection); 

			try
			{
                
                string queryInsertTask = query.queryInsertTask ; // Added query (insert task in sql)
                SqlCommand cmd = new SqlCommand(queryInsertTask, connection); 

                connection.Open();

                // Add parameters to the SQL
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@info", info);
                cmd.Parameters.AddWithValue("@date", Date);

                cmd.ExecuteNonQuery(); 

                MessageBox.Show(massage.msSucess, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
			catch
			{
                MessageBox.Show(massage.msUnSucess, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            finally
            {
                connection.Close(); // The database connection should be closed after it is opened
            }

        }// End method CreateTaskBtn
    }
}
