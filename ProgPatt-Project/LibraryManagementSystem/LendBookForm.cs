using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lend_Book
{
    public partial class LendBookForm : Form
    {
        private int Row;

        public LendBookForm(int row)
        {
            InitializeComponent();
            this.Row = row;
        }

        private void LendButton_Click(object sender, EventArgs e)
        {
            // Get info
            string userIdStr = userListBox.GetItemText(userListBox.SelectedItem);
            int userId = int.Parse(userIdStr);
            string bookIdStr = bookIdTextBox.Text;
            int bookId = int.Parse(bookIdStr);

            // Set borrower of book
            this.bookTableAdapter.LendBook(bookId, userId);

            MessageBox.Show("Book lended.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void LendBookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.libraryDatabaseDataSet.User);

            bookBindingSource.Position = this.Row;
        }
    }
}
