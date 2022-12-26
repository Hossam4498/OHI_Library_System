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
    class ExamsPresenter
    {
        IExams iexams;
        ExamsModel examsModel = new ExamsModel();


        public ExamsPresenter(IExams view)
        {
            this.iexams = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            examsModel.Exam_ID = iexams.Exam_ID;
            examsModel.Exam_Description = iexams.Exam_Description;
            examsModel.Doctor_ID = iexams.Doctor_ID;
        }


        public bool ExamsInsert()
        {
            connectBetweenModelInterface();
            return ExamsService.examInsert(examsModel.Exam_ID, examsModel.Exam_Description, Convert.ToInt32(examsModel.Doctor_ID));
        }


        public bool ExamsUpdate()
        {
            connectBetweenModelInterface();
            return ExamsService.examUpdate(examsModel.Exam_ID, examsModel.Exam_Description, Convert.ToInt32(examsModel.Doctor_ID));
        }


        public bool ExamsDelete()
        {
            connectBetweenModelInterface();
            return ExamsService.examDelete(examsModel.Exam_ID);
        }


        public bool ExamsDeleteAll()
        {
            connectBetweenModelInterface();
            return ExamsService.examDeleteAll();
        }


        public void ClearFields()
        {
            connectBetweenModelInterface();

            iexams.Exam_ID = Convert.ToInt32("");
            iexams.Exam_Description = "";
            iexams.Doctor_ID = "";
        }
    }
}
