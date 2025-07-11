using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanban_ToDoList.Constant
{
    /// <summary>
    ///  This method manages queries.
    /// </summary>
    internal class Query
    {
        // Database connection variables
        const string Server = "Moein2008";
        const string DB = "ToDoList";
        const string user = "sa";
        const string pass = "arta0@";

        // query
        public string connection = $"Data Source=.\\{Server};Initial Catalog={DB};User Id={user};Password={pass};TrustServerCertificate=True";
        public string queryInsertTask = "INSERT INTO Tasks (Title, Info, Date, StageId) VALUES (@title, @info, @date, 1)";
        public string loadToDoQuery = "SELECT Id, Title FROM Tasks where StageId =";
        public string queryUpdateTask = "update tasks set Info =";
    }
}
