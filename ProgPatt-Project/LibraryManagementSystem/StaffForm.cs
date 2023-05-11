using Lend_Book;
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
    public partial class StaffForm : Form
    {
        private int StaffId;
        private string Username;

        public StaffForm(int staffId, string username)
        {
            InitializeComponent();
            this.StaffId = staffId;
            this.Username = username;
        }

        private void StaffSearchBookForm_Load(object sender, EventArgs e)
        {
            // Disable x button
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
            welcomeLabel.Text = "Welcome User " + Username;
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            // Show AddBookForm
            AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();

            // Update DataGridView after insertion of book
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchStr = searchTextBox.Text;
            this.bookTableAdapter.SearchTitle(this.libraryDatabaseDataSet.Book, searchStr);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void modifyBookButton_Click(object sender, EventArgs e)
        {
            int selectedRow = bookDataGridView.CurrentCell.RowIndex;
            ModifyBookForm modifyBookForm = new ModifyBookForm(selectedRow);
            modifyBookForm.ShowDialog();

            // Show modified data in DataGridView
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void lendBookButton_Click(object sender, EventArgs e)
        {
            int selectedRow = bookDataGridView.CurrentCell.RowIndex;
            LendBookForm lendBookForm = new LendBookForm(selectedRow);
            
            // Show form
            lendBookForm.ShowDialog();

            // Update table
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormProvider.GetLoginForm().Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }
    }
}
