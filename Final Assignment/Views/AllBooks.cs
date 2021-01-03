using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Assignment.Models;
using Final_Assignment.Controllers;

namespace Final_Assignment.Views
{
    public partial class AllBooks : Form
    {
        public AllBooks()
        {
            InitializeComponent();
            dataGridViewAllBooks.DataSource = BookController.GetBooks();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewAllBooks.DataSource=BookController.SearchBook(textBoxSearch.Text);
        }

        private void dataGridViewAllBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Book c = new Book();
            c.Id = Int32.Parse(this.dataGridViewAllBooks.CurrentRow.Cells[0].Value.ToString());
            c.Name = this.dataGridViewAllBooks.CurrentRow.Cells[1].Value.ToString();
            c.Author= this.dataGridViewAllBooks.CurrentRow.Cells[2].Value.ToString();
            c.Edition= this.dataGridViewAllBooks.CurrentRow.Cells[3].Value.ToString();
            new Book_Detail(c).Show();
        }
    }
}
