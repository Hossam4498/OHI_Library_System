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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHI_Library_System.Views.Forms
{
    public partial class Students_Form : DevExpress.XtraEditors.XtraForm, IStudents
    {
        StudentsPresenter studentsPresenter;

        public Students_Form()
        {
            InitializeComponent();
            studentsPresenter = new StudentsPresenter(this);
        }


        public int Student_ID { get => Convert.ToInt32(studentID.Text); set => studentID.Text = value.ToString(); }
        public string Student_Name { get => studentName.Text; set => studentName.Text = value; }
        public string Student_Phone { get => studentPhone.Text; set => studentPhone.Text = value; }
        public string Student_Department { get => studentDepartment.Text; set => studentDepartment.Text = value; }
        public string Student_Year { get => studentYear.Text; set => studentYear.Text = value; }

        private void btnNew_Click(object sender, EventArgs e)
        {
            studentsPresenter.ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = studentsPresenter.StudentsUpdate();

            if (check)
            {
                MessageBox.Show("Data Is Updated Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Update Data 💔");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = studentsPresenter.StudentsInsert();

            if (check)
            {
                MessageBox.Show("Data Is Added Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Add Data 💔");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = studentsPresenter.StudentsDelete();

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
            bool check = studentsPresenter.StudentsDeleteAll();

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