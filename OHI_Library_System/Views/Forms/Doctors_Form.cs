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
    public partial class Doctors_Form : DevExpress.XtraEditors.XtraForm, IDoctors
    {
        DoctorsPresenter doctorsPresenter;

        public Doctors_Form()
        {
            InitializeComponent();
            doctorsPresenter = new DoctorsPresenter(this);
        }

        public int Doctor_ID { get => Convert.ToInt32(doctorID.Text); set => doctorID.Text = value.ToString(); }
        public string Doctor_Name { get => doctorName.Text; set => doctorName.Text = value; }
        public string Doctor_Phone { get => doctorPhone.Text; set => doctorPhone.Text = value; }
        public string Doctor_Department { get => doctorDepartment.Text; set => doctorDepartment.Text = value; }


        private void btnNew_Click(object sender, EventArgs e)
        {
            doctorsPresenter.ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = doctorsPresenter.DoctorsInsert();

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
            bool check = doctorsPresenter.DoctorsDelete();

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
            bool check = doctorsPresenter.DoctorsDeleteAll();

            if (check)
            {
                MessageBox.Show("All Date Are Deleted Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Delete All Data 💔");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = doctorsPresenter.DoctorsUpdate();

            if (check)
            {
                MessageBox.Show("Data Is Updated Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Update Data 💔");
            }
        }
    }
}