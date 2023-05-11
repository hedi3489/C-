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
    public partial class ModifyBookForm : Form
    {
        private int Row;
        public ModifyBookForm(int row)
        {
            InitializeComponent();
            this.Row = row;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            // Call update function to update record
            string bookIdStr = bookIdTextBox.Text;
            int bookId = int.Parse(bookIdStr);
            string title = bookTitleTextBox.Text;
            string author = authorTextBox.Text;
            DateTime publishDate = publishDateDateTimePicker.Value;
            string publishDateStr = publishDate.ToLongDateString();
            this.bookTableAdapter.UpdateBookById(bookId, title, author, publishDateStr);
            // Show book modified message
            MessageBox.Show("Book modified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // close this ModifyBookForm
            this.Close();
        }

        private void ModifyBookForm_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
            bookBindingSource.Position = Row;
        }
    }
}
