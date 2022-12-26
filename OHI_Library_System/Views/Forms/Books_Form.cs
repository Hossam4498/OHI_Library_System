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
    public partial class Books_Form : DevExpress.XtraEditors.XtraForm, IBooks
    {
        BooksPresenter booksPresenter;

        public Books_Form()
        {
            InitializeComponent();
            booksPresenter = new BooksPresenter(this);
        }

        public int Book_ID { get => Convert.ToInt32(bookID.Text); set => bookID.Text = value.ToString(); }
        public string Book_Category { get => bookCategory.Text; set => bookCategory.Text = value; }
        public string Book_Name { get => bookName.Text; set => bookName.Text = value; }
        public string Author { get => author.Text; set => author.Text = value; }
        public string Copyright { get => copyright.Text; set => copyright.Text = value; }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool check = booksPresenter.BooksInsert();

            if (check)
            {
                MessageBox.Show("Data Is Added Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Add Data 💔");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            bool check = booksPresenter.BooksUpdate();

            if (check)
            {
                MessageBox.Show("Data Is Updated Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Update Data 💔");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            bool check = booksPresenter.BooksDelete();

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
            bool check = booksPresenter.BooksDeleteAll();

            if (check)
            {
                MessageBox.Show("All Date Are Deleted Successfully 👌");
            }
            else
            {
                MessageBox.Show("Failed To Delete All Data 💔");
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            booksPresenter.ClearFields();
        }
    }
}