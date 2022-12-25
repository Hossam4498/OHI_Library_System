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
    class BooksPresenter
    {
        IBooks ibooks;
        BooksModel booksModel = new BooksModel();


        public BooksPresenter(IBooks view)
        {
            this.ibooks = view;
        }


        // Connect between model books and interface books.
        private void connectBetweenModelInterface()
        {
            booksModel.Book_ID = ibooks.Book_ID;
            booksModel.Book_Category = ibooks.Book_Category;
            booksModel.Book_Name = ibooks.Book_Name;
            booksModel.Author = ibooks.Author;
            booksModel.Copyright = ibooks.Copyright;
        }


        public bool BooksInsert()
        {
            connectBetweenModelInterface();
            return BooksService.bookInsert(booksModel.Book_ID, booksModel.Book_Category, booksModel.Book_Name, booksModel.Author, booksModel.Copyright);
        }
    }
}
