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
    class DoctorsPresenter
    {
        IDoctors idoctors;
        DoctorsModel doctorsModel = new DoctorsModel();


        public DoctorsPresenter(IDoctors view)
        {
            this.idoctors = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            doctorsModel.Doctor_ID = idoctors.Doctor_ID;
            doctorsModel.Doctor_Name = idoctors.Doctor_Name;
            doctorsModel.Doctor_Phone = idoctors.Doctor_Phone;
            doctorsModel.Doctor_Department = idoctors.Doctor_Department;
        }


        public bool DoctorsInsert()
        {
            connectBetweenModelInterface();
            return DoctorsService.doctorInsert(doctorsModel.Doctor_ID, doctorsModel.Doctor_Name, doctorsModel.Doctor_Phone, doctorsModel.Doctor_Department);
        }


        public bool DoctorsUpdate()
        {
            connectBetweenModelInterface();
            return DoctorsService.doctorUpdate(doctorsModel.Doctor_ID, doctorsModel.Doctor_Name, doctorsModel.Doctor_Phone, doctorsModel.Doctor_Department);
        }


        public bool DoctorsDelete()
        {
            connectBetweenModelInterface();
            return DoctorsService.doctorDelete(doctorsModel.Doctor_ID);
        }


        public bool DoctorsDeleteAll()
        {
            connectBetweenModelInterface();
            return DoctorsService.doctorDeleteAll();
        }


        public void ClearFields()
        {
            connectBetweenModelInterface();

            idoctors.Doctor_ID = 0;
            idoctors.Doctor_Name = "";
            idoctors.Doctor_Phone = "";
            idoctors.Doctor_Department = "";
        }

    }
}
