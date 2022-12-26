using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class ExamsService
    {
        public static bool examInsert(int id, string description, int doctor_id)
        {
            return DBHelper.executeData("examInsert", () => examParameterInsert(id, description, doctor_id, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void examParameterInsert(int id, string description, int doctor_id, SqlCommand command)
        {
            command.Parameters.Add("@Exam_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Exam_Description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = doctor_id;
        }


        public static bool examDelete(int id)
        {
            return DBHelper.executeData("examDelete", () => examParameterDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void examParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Exam_ID", SqlDbType.Int).Value = id;
        }


        public static bool examUpdate(int id, string description, int doctor_id)
        {
            return DBHelper.executeData("examUpdate", () => examParameterUpdate(id, description, doctor_id, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void examParameterUpdate(int id, string description, int doctor_id, SqlCommand command)
        {
            command.Parameters.Add("@Exam_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Exam_Description", SqlDbType.NVarChar).Value = description;
            command.Parameters.Add("@Doctor_ID", SqlDbType.Int).Value = doctor_id;
        }


        public static bool examDeleteAll()
        {
            return DBHelper.executeData("examDeleteAll", () => examParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void examParameterDeleteAll()
        {

        }
    }
}
