using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OHI_Library_System.Logic.Services
{
    static class BooksService
    {
        public static bool bookInsert(int id, string category, string name, string author, string copyright)
        {
            return DBHelper.executeData("bookInsert", () => bookParameterInsert(id, category, name, author, copyright, DBHelper.command));
        }

        // This method to add insert parameter into stored procedure
        private static void bookParameterInsert(int id, string category, string name, string author, string copyright, SqlCommand command)
        {
            command.Parameters.Add("@Book_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Book_Category", SqlDbType.NVarChar).Value = category;
            command.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = author;
            command.Parameters.Add("@Copyright", SqlDbType.NVarChar).Value = copyright;
        }


        public static bool bookDelete(int id)
        {
            return DBHelper.executeData("bookDelete", () => bookParameterDelete(id, DBHelper.command));
        }

        // This method to delete parameter into stored procedure
        private static void bookParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@Book_ID", SqlDbType.Int).Value = id;
        }


        public static bool bookUpdate(int id, string category, string name, string author, string copyright)
        {
            return DBHelper.executeData("bookUpdate", () => bookParameterUpdate(id, category, name, author, copyright, DBHelper.command));
        }

        // This method to Update parameter into stored procedure
        private static void bookParameterUpdate(int id, string category, string name, string author, string copyright, SqlCommand command)
        {
            command.Parameters.Add("@Book_ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Book_Category", SqlDbType.NVarChar).Value = category;
            command.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@Author", SqlDbType.NVarChar).Value = author;
            command.Parameters.Add("@Copyright", SqlDbType.NVarChar).Value = copyright;
        }


        public static bool bookDeleteAll()
        {
            return DBHelper.executeData("bookDeleteAll", () => bookParameterDeleteAll());
        }

        // This method to delete all parameter into stored procedure
        private static void bookParameterDeleteAll()
        {
            
        }
    }



}
