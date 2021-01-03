using Final_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Final_Assignment.Controllers
{
    public class BookController
    {
        static Database db = new Database();
        public static ArrayList GetBooks()
        { return db.Books.GetAllBooks(); }
        public static ArrayList SearchBook(string value)
        { return db.Books.SearchBooks(value); }
    }
}
