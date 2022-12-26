using DevExpress.XtraEditors;
using DevExpress.XtraReports.Templates;
using OHI_Library_System.Logic.Presenter;
using OHI_Library_System.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHI_Library_System.Views.Forms
{
    public partial class Exams_Form : DevExpress.XtraEditors.XtraForm, IExams
    {
        ExamsPresenter examsPresenter;

        public Exams_Form()
        {
            InitializeComponent();
            examsPresenter = new ExamsPresenter(this);
        }


        public int Exam_ID { get => Convert.ToInt32(examID.Text); set => examID.Text = value.ToString(); }
        public string Exam_Description { get => examDescription.Text; set => examDescription.Text = value; }
        public string Doctor_ID { get => doctorID.Text; set => doctorID.Text = value; }


        private void btnNew_Click(object sender, EventArgs e)
        {
            examsPresenter.ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = examsPresenter.ExamsInsert();

            if (check)
            {
                MessageBox.Show("Data Is Added Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Add Data 💔");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = examsPresenter.ExamsUpdate();

            if (check)
            {
                MessageBox.Show("Data Is Updated Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Update Data 💔");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = examsPresenter.ExamsDelete();

            if (check)
            {
                MessageBox.Show("Data Is Deleted Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Delete Data 💔");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            bool check = examsPresenter.ExamsDeleteAll();

            if (check)
            {
                MessageBox.Show("All Date Are Deleted Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Delete All Data 💔");
            }
        }
    }
}