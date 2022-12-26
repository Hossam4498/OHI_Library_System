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
    public partial class Tools_Form : DevExpress.XtraEditors.XtraForm, ITools
    {
        ToolsPresenter toolsPresenter;

        public Tools_Form()
        {
            InitializeComponent();
            toolsPresenter = new ToolsPresenter(this);
        }


        public int Tool_ID { get => Convert.ToInt32(toolID.Text); set => toolID.Text = value.ToString(); }
        public string Tool_Name { get => toolName.Text; set => toolName.Text = value; }
        public string Tool_Description { get => toolDescription.Text; set => toolDescription.Text = value; }


        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            toolsPresenter.ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check = toolsPresenter.ToolsInsert();

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
            bool check = toolsPresenter.ToolsUpdate();

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
            bool check = toolsPresenter.ToolsDelete();

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
            bool check = toolsPresenter.ToolsDeleteAll();

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