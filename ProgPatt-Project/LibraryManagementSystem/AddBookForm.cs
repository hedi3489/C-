using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            string title = bookTitleTextBox.Text;
            string author = authorTextBox.Text;
            DateTime publishDate = publishDateDateTimePicker.Value;

            this.bookTableAdapter.Insert(title, author, publishDate, null);
            MessageBox.Show("Book added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
