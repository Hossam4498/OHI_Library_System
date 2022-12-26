using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class ToolsService
    {
        public static bool toolInsert(int id, string name, string description)
        {
            return DBHelper.executeData("toolInsert", () => toolParameterInsert(id, name, description, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void toolParameterInsert(int id, string name, string description, SqlCommand command)
        {
            command.Parameters.Add("@Tool_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Tool_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Tool_Descrition", SqlDbType.NVarChar).Value = description;
        }


        public static bool toolDelete(int id)
        {
            return DBHelper.executeData("toolDelete", () => toolParameterDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void toolParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Tool_ID", SqlDbType.Int).Value = id;
        }


        public static bool toolUpdate(int id, string name, string description)
        {
            return DBHelper.executeData("toolUpdate", () => toolParameterUpdate(id, name, description, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void toolParameterUpdate(int id, string name, string description, SqlCommand command)
        {
            command.Parameters.Add("@Tool_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Tool_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Tool_Descrition", SqlDbType.NVarChar).Value = description;
        }


        public static bool toolDeleteAll()
        {
            return DBHelper.executeData("toolDeleteAll", () => toolParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void toolParameterDeleteAll()
        {

        }
    }
}
