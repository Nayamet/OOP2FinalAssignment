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

namespace Final_Assignment.Views
{
    public partial class Book_Detail : Form
    {
        public Book_Detail(Book obj)
        {
            InitializeComponent();
            textBoxId.Text = obj.Id.ToString();
            textBoxName.Text = obj.Name;
            textBoxAuthor.Text = obj.Author;
            textBoxEdition.Text = obj.Edition;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
