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
    public partial class SupplierForm : Form
    {
        private int SupplierId;
        private string Username;

        public SupplierForm(int supplierId, string username)
        {
            InitializeComponent();
            this.SupplierId = supplierId;
            this.Username = username;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            // Disable x button
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
            
            // display username in form
            welcomeLabel.Text = "Welcome User " + Username;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string title = searchTextBox.Text;
            this.bookTableAdapter.SearchTitle(this.libraryDatabaseDataSet.Book, title);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void sellBookButton_Click(object sender, EventArgs e)
        {
            SellBookForm sellBookForm = new SellBookForm();
            sellBookForm.ShowDialog();
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormProvider.GetLoginForm().Show();
        }
    }
}
