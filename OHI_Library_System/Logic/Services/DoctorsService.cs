using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class DoctorsService
    {
        public static bool doctorInsert(int id, string name, string phone, string department)
        {
            return DBHelper.executeData("doctorInsert", () => doctorParameterInsert(id, name, phone, department, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void doctorParameterInsert(int id, string name, string phone, string department, SqlCommand command)
        {
            command.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Doctor_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Doctor_Phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@Doctor_Department", SqlDbType.NVarChar).Value = department;
        }


        public static bool doctorDelete(int id)
        {
            return DBHelper.executeData("doctorDelete", () => doctorParameterDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void doctorParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = id;
        }


        public static bool doctorUpdate(int id, string name, string phone, string department)
        {
            return DBHelper.executeData("doctorUpdate", () => doctorParameterUpdate(id, name, phone, department, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void doctorParameterUpdate(int id, string name, string phone, string department, SqlCommand command)
        {
            command.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Doctor_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Doctor_Phone", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@Doctor_Department", SqlDbType.NVarChar).Value = department;
        }


        public static bool doctorDeleteAll()
        {
            return DBHelper.executeData("doctorDeleteAll", () => doctorParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void doctorParameterDeleteAll()
        {

        }
    }
}
