using Kanban_ToDoList.Constant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList
{
    internal class UploadTask : IUploadTask
    {
        /// <summary>
        /// This method gets the title and info of a task using taskId,
        /// and sends (uploads) it to the EditTaskForm.
        /// </summary>
        /// <param name="taskId">Receives taskId</param>
        /// <returns>returns title and info tuple</returns>
        public (string title, string info) Upload(int taskId)
        {
            Messages massage = new Messages();
            Query query = new Query();
            SqlConnection connection = new SqlConnection(query.connection);
            try
            {
                connection.Open();  
                string queryUploadTitle = query.uploadTitle + taskId; // Upload query task where taskId is true
                SqlDataAdapter adapter = new SqlDataAdapter(queryUploadTitle, connection); 
                DataTable date = new DataTable();
                adapter.Fill(date);

                // Gets title and info
                string title = date.Rows[0]["Title"].ToString();
                string info = date.Rows[0]["Info"].ToString();

                return (title,info);

            }
            catch
            {
                return (massage.msErroUplodaTitle,massage.msErroUplodaInfo); // return messages Errors
            }

        }// End method Upload
    }
}
