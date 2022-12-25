using DevExpress.XtraEditors;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool check = booksPresenter.BooksInsert();

            if (check)
            {
                MessageBox.Show("Added Successfully 👌");
            }
            else
            {
                MessageBox.Show("Addition Failed 💔");
            }
        }
    }
}