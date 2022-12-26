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
    public partial class Graduation_Projects_Form : DevExpress.XtraEditors.XtraForm, IGraduationProjects
    {
        GraduationProjectsPresenter graduationProjectsPresenter;

        public Graduation_Projects_Form()
        {
            InitializeComponent();
            graduationProjectsPresenter = new GraduationProjectsPresenter(this);
        }


        public int Project_ID { get => Convert.ToInt32(projectID.Text); set => projectID.Text = value.ToString(); }
        public string Project_Name { get => projectName.Text; set => projectName.Text = value; }
        public string Project_Department { get => projectDepartment.Text; set => projectDepartment.Text = value; }
        public string Project_Year { get => projectYear.Text; set => projectYear.Text = value; }
        public string Student_Name { get => studentName.Text; set => studentName.Text = value; }


        private void studentName_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            graduationProjectsPresenter.ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = graduationProjectsPresenter.GraduationProjectsInsert();

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
            bool check = graduationProjectsPresenter.GraduationProjectsUpdate();

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
            bool check = graduationProjectsPresenter.GraduationProjectsDelete();

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
            bool check = graduationProjectsPresenter.GraduationProjectsDeleteAll();

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