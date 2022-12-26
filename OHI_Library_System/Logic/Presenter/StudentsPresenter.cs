using OHI_Library_System.Logic.Services;
using OHI_Library_System.Models;
using OHI_Library_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Logic.Presenter
{
    class StudentsPresenter
    {
        IStudents istudents;
        StudentsModel studentsModel = new StudentsModel();


        public StudentsPresenter(IStudents view)
        {
            this.istudents = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            studentsModel.Student_ID = istudents.Student_ID;
            studentsModel.Student_Name = istudents.Student_Name;
            studentsModel.Student_Phone = istudents.Student_Phone;
            studentsModel.Student_Department = istudents.Student_Department;
            studentsModel.Student_Year = istudents.Student_Year;
        }


        public bool StudentsInsert()
        {
            connectBetweenModelInterface();
            return StudentsService.studentInsert(studentsModel.Student_ID, studentsModel.Student_Name, studentsModel.Student_Phone, studentsModel.Student_Department, studentsModel.Student_Year);
        }


        public bool StudentsUpdate()
        {
            connectBetweenModelInterface();
            return StudentsService.studentUpdate(studentsModel.Student_ID, studentsModel.Student_Name, studentsModel.Student_Phone, studentsModel.Student_Department, studentsModel.Student_Year);
        }


        public bool StudentsDelete()
        {
            connectBetweenModelInterface();
            return StudentsService.studentDelete(studentsModel.Student_ID);
        }


        public bool StudentsDeleteAll()
        {
            connectBetweenModelInterface();
            return StudentsService.studentDeleteAll();
        }


        public void ClearFields()
        {
            connectBetweenModelInterface();

            istudents.Student_ID = 0;
            istudents.Student_Name = "";
            istudents.Student_Phone = "";
            istudents.Student_Department = "";
            istudents.Student_Year = "";
        }
    }
}
