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
        const string Server = "Moein2012";
        const string DB = "ToDoList";
        const string user = "sa";
        const string pass = "arta0@";
        const string table = "tasks";

        // query
        public string connection = $"Data Source=.\\{Server};Initial Catalog={DB};User Id={user};Password={pass};TrustServerCertificate=True";
        public string queryInsertTask = $"INSERT INTO {table} (Title, Info, Date, StageId) VALUES (@title, @info, @date, 1)";
        public string loadToDoQuery = $"SELECT Id, Title FROM {table} where StageId =";
        public string queryUpdateTask = $"update {table} set Info =";
        public string uploadTitle = $"select * from {table} where ID=";
        public string uploadInfo = $"select Info from {table} where ID=";
    }
}
