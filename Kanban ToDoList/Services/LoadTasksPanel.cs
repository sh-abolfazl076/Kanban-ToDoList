using Kanban_ToDoList.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban_ToDoList.Constant
{
    internal class LoadTasksPanel : ILoadTasksPanel
    {


        Messages massage = new Messages(); // Create an instance massage.
        Query query = new Query(); // Create an instance query.

        /// <summary>
        /// Loads task data from the database where the status is "StageId"
        /// </summary>
        /// <param name="PanelToDo">The FlowLayoutPanel where task buttons will be added.</param>
        public void LoadTasksInfoPanal(FlowLayoutPanel PanelToDo , int StageId)
        {
            SqlConnection connection = new SqlConnection(query.connection); // Create a new SQL connetion 

            try
            {
                string queryInsertTask = query.loadToDoQuery + StageId; // The query to load tasks where the status is "StageId" 
                SqlCommand cmd = new SqlCommand(queryInsertTask, connection); // Create a SQL command using the query and the database connetion
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                LoadTaskBtns btns = new LoadTaskBtns(); // Create an instance btns.
                btns.CreateBtn(reader, PanelToDo); // Call CreateBtn method 

            }
            catch (Exception)
            {
                MessageBox.Show(massage.msUnLoade, massage.UnSucess, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close(); // The database connection should be closed after it is opened
            }
        }// End Method LoadTasksInfoPanalToDo
    }
}
