using LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class UserForm : Form
    {
        private int UserId;
        private string Username;
        public UserForm(int userId, string username)
        {
            InitializeComponent();
            this.UserId = userId;
            this.Username = username;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            // Disable x button
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
            welcomeLabel.Text = "Welcome User " + this.Username;

            // TODO: This line of code loads data into the 'libraryDatabaseDataSet.WaitingList' table. You can move, or remove it, as needed.
            this.waitingListTableAdapter1.Fill(this.libraryDatabaseDataSet.WaitingList);

            if ((bool)userTableAdapter.GetDataByUserId(UserId).Rows[0]["IsMember"] == true)
            {
                // Notify the user on the waiting list when a requested Book is returned.
                BookReturnedNotification();
                // Notify the user if he borrowed a requested book that he must return it asap.
                BookRequestedNotification();
            }
        }

        public void BookReturnedNotification()
        {
            DataTable waitingList = waitingListTableAdapter1.GetDataByUserId(UserId);
            if (waitingListTableAdapter1.CountBooks(UserId) != 0)
            {
                string returnedBooks = "";
                int numOfBooks = 0;
                foreach (DataRow waiter in waitingList.Rows)
                {
                    int bookid = int.Parse(waiter["BookId"].ToString());
                    DataTable books = bookTableAdapter.GetBookRow(bookid);
                    DataRow book = books.Rows[0];
                    string bookTitle = book["BookTitle"].ToString();
                    if ((bool)waiter["IsReturned"] == true)
                    {
                        returnedBooks += "'" + bookTitle + "', ";
                        this.waitingListTableAdapter1.Delete(bookid, UserId, true);
                        numOfBooks++;
                    }
                }
                if (numOfBooks == 1)
                {
                    MessageBox.Show("The book " + returnedBooks + "you have requested " +
                        "has been returned and is free to borrow.", "A Book Awaits You!");
                }
                else if (numOfBooks > 1)
                {
                    MessageBox.Show("The books " + returnedBooks + "you have requested " +
                        "have been returned and are free to borrow.", "Books Awaits You!");
                }
            }
        }

        public void BookRequestedNotification()
        {
            // Selecting Books borrowed by current User.
            DataTable books = bookTableAdapter.GetBooksByUserID(UserId);
            
            if(books.Rows.Count > 0)
            {
                string requestedBooks = "";
                int numOfReqBooks = 0;
                foreach (DataRow book in books.Rows)
                {
                    // Checking if @book of the borrowed books exists in the waiting list.
                    int bookId = int.Parse(book["BookId"].ToString());
                    int numOfBooks = int.Parse(waitingListTableAdapter1.CountBooksByBookId(bookId).ToString());
                    
                    // If yes add it title to requested books.
                    if (numOfBooks >= 1) 
                    {
                        requestedBooks += " '" + book["BookTitle"] + "', ";
                        numOfReqBooks++;
                    }
                }
                if(numOfReqBooks == 1)
                {
                    MessageBox.Show("The book " + requestedBooks + "you have borrowed has been requested by other users. Please return it as soon as possible. " +
                        "\nThank you!", "A Borrowed Book Has Been Requested!");
                }
                else if (numOfReqBooks > 1)
                {
                    MessageBox.Show("The books " + requestedBooks + "you have borrowed have been requested by other users. Please return them as soon as possible. " +
                        "\nThank you!", "Borrowed Book Have Been Requested!");
                }
            }
        }

        private void borrowBookButton_Click(object sender, EventArgs e)
        {
            string bookIdStr = bookListBox.GetItemText(bookListBox.SelectedItem);
            int bookId = int.Parse(bookIdStr);

            DataTable bookUserIdTable = bookTableAdapter.GetBookRow(bookId);
            DataRow bookUserIdRow = bookUserIdTable.Rows[0];

            string userIdStr = bookUserIdRow["UserId"].ToString();
            if (userIdStr == "")
            {
                // Borrow book to user if there are no borrowers
                this.bookTableAdapter.BorrowBook(bookId, UserId);
                this.bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
                MessageBox.Show("Book borrowed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int userId = int.Parse(userIdStr);
                if (userId == UserId)
                {
                    // Check if the current logged in user is already specified as the user who borrowed this book
                    MessageBox.Show("The book has already been borrowed by you.", "Borrow Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // The book is already borrowed by someone else
                    DialogResult userAnswer = MessageBox.Show("The book you want to borrow is already borrowed by someone else. Would you like to be added to the waiting list for this book?", "Borrow Book", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (userAnswer == DialogResult.Yes)
                    {
                        try
                        {
                            waitingListTableAdapter1.Insert(bookId, UserId, false);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("You are already in the waiting list for this book.", "Already in Waiting List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            string bookIdStr = bookListBox.GetItemText(bookListBox.SelectedItem);
            int bookId = int.Parse(bookIdStr);
            DataTable bookRowTable = bookTableAdapter.GetBookRow(bookId);
            DataRow bookRow = bookRowTable.Rows[0];

            string userIdStr = bookRow["UserId"].ToString();
            int userId = -1;
            if (userIdStr != "")
            {
                userId = int.Parse(userIdStr);
            }

            if (userIdStr == "")
            {
                MessageBox.Show("You may not return a book that belongs to no one.", "Returning...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userId != UserId)
            {
                MessageBox.Show("This book does not belong to you. Cannot return this book.", "Cannot return this book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // The book belongs to the user that is currently logged in
                bookTableAdapter.ReturnBook(bookId);
                bookTableAdapter.Fill(this.libraryDatabaseDataSet.Book);
                MessageBox.Show("Book returned!", "Returning...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.waitingListTableAdapter1.UpdateIsReturned(true, bookId);
            }
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

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormProvider.GetLoginForm().Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            userTableAdapter.UpdateMembership(true,UserId);
            MessageBox.Show("You are now a library member. You will be notified upon logging in of the return of " +
                "your requested books. You will also be notified when other members request a book that you borrowed " +
                "to keep our book collection as accessibe as possible.\nThank You for becoming a member!", 
                "Welcome New Member!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            userTableAdapter.UpdateMembership(false, UserId);
            MessageBox.Show("Your membership was cancelled. You will no longer be notified of returned books or to " +
                "return books requested by other members.", "Goodbye Member!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
