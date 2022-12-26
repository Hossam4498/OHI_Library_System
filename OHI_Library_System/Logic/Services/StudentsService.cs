using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class StudentsService
    {
        public static bool studentInsert(int id, string name, string phone, string department, string year)
        {
            return DBHelper.executeData("studentInsert", () => studentParameterInsert(id, name, phone, department, year, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void studentParameterInsert(int id, string name, string phone, string department, string year, SqlCommand command)
        {
            command.Parameters.Add("@Student_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Student_Phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@Student_Department", SqlDbType.NVarChar).Value = department;
            command.Parameters.Add("@Student_Year", SqlDbType.NVarChar).Value = year;
        }


        public static bool studentDelete(int id)
        {
            return DBHelper.executeData("studentDelete", () => studentParameterDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void studentParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Student_ID", SqlDbType.Int).Value = id;
        }


        public static bool studentUpdate(int id, string name, string phone, string department, string year)
        {
            return DBHelper.executeData("studentUpdate", () => studentParameterUpdate(id, name, phone, department, year, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void studentParameterUpdate(int id, string name, string phone, string department, string year, SqlCommand command)
        {
            command.Parameters.Add("@Student_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Student_Phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@Student_Department", SqlDbType.NVarChar).Value = department;
            command.Parameters.Add("@Student_Year", SqlDbType.NVarChar).Value = year;
        }


        public static bool studentDeleteAll()
        {
            return DBHelper.executeData("studentDeleteAll", () => studentParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void studentParameterDeleteAll()
        {

        }
    }
}
