using OHI_Library_System.Logic.Services;
using OHI_Library_System.Models;
using OHI_Library_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Logic.Presenter
{
    class GraduationProjectsPresenter
    {
        IGraduationProjects igraduationProjects;
        GraduationProjectsModel graduationProjectsModel = new GraduationProjectsModel();


        public GraduationProjectsPresenter(IGraduationProjects view)
        {
            this.igraduationProjects = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            graduationProjectsModel.Project_ID = igraduationProjects.Project_ID;
            graduationProjectsModel.Project_Name = igraduationProjects.Project_Name;
            graduationProjectsModel.Project_Department = igraduationProjects.Project_Department;
            graduationProjectsModel.Project_Year = igraduationProjects.Project_Year;
            graduationProjectsModel.Student_Name = igraduationProjects.Student_Name;
        }


        public bool GraduationProjectsInsert()
        {
            connectBetweenModelInterface();
            return GraduationProjectsService.graduationProjectsInsert(graduationProjectsModel.Project_ID, graduationProjectsModel.Project_Name, graduationProjectsModel.Project_Department, graduationProjectsModel.Project_Year, graduationProjectsModel.Student_Name);
        }


        public bool GraduationProjectsUpdate()
        {
            connectBetweenModelInterface();
            return GraduationProjectsService.graduationProjectsUpdate(graduationProjectsModel.Project_ID, graduationProjectsModel.Project_Name, graduationProjectsModel.Project_Department, graduationProjectsModel.Project_Year, graduationProjectsModel.Student_Name);
        }


        public bool GraduationProjectsDelete()
        {
            connectBetweenModelInterface();
            return GraduationProjectsService.graduationProjectsDelete(graduationProjectsModel.Project_ID);
        }


        public bool GraduationProjectsDeleteAll()
        {
            connectBetweenModelInterface();
            return GraduationProjectsService.graduationProjectsDeleteAll();
        }


        public void ClearFields()
        {
            connectBetweenModelInterface();

            igraduationProjects.Project_ID = 0;
            igraduationProjects.Project_Name = "";
            igraduationProjects.Project_Department = "";
            igraduationProjects.Project_Year = "";
            igraduationProjects.Student_Name = "";
        }
    }
}
