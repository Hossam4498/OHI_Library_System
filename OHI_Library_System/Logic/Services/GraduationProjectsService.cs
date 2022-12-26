using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class GraduationProjectsService
    {
        public static bool graduationProjectsInsert(int id, string name, string department, string year, string student_name)
        {
            return DBHelper.executeData("graduationProjectsInsert", () => graduationProjectsInsert(id, name, department, year, student_name, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void graduationProjectsInsert(int id, string name, string department, string year, string student_name, SqlCommand command)
        {
            command.Parameters.Add("@Project_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Project_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Project_Department", SqlDbType.NVarChar).Value = department;
            command.Parameters.Add("@Project_Year", SqlDbType.NVarChar).Value = year;
            command.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = student_name;
        }


        public static bool graduationProjectsDelete(int id)
        {
            return DBHelper.executeData("graduationProjectsDelete", () => graduationProjectsDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void graduationProjectsDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Project_ID", SqlDbType.Int).Value = id;
        }


        public static bool graduationProjectsUpdate(int id, string name, string department, string year, string student_name)
        {
            return DBHelper.executeData("graduationProjectsUpdate", () => graduationProjectsParameterUpdate(id, name, department, year, student_name, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void graduationProjectsParameterUpdate(int id, string name, string department, string year, string student_name, SqlCommand command)
        {
            command.Parameters.Add("@Project_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Project_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Project_Department", SqlDbType.NVarChar).Value = department;
            command.Parameters.Add("@Project_Year", SqlDbType.NVarChar).Value = year;
            command.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = student_name;
        }


        public static bool graduationProjectsDeleteAll()
        {
            return DBHelper.executeData("graduationProjectsDeleteAll", () => graduationProjectsParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void graduationProjectsParameterDeleteAll()
        {

        }
    }
}
