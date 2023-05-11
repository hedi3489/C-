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
    public partial class SellBookForm : Form
    {
        public SellBookForm()
        {
            InitializeComponent();
        }

        private void SellBookForm_Load(object sender, EventArgs e)
        {
            publishDateDateTimePicker.MaxDate = DateTime.Today;
        }

        private void sellBookButton_Click(object sender, EventArgs e)
        {
            // Insert into the Book table the values inserted into the Sell Book Form
            
            string title = bookTitleTextBox.Text;
            string author = authorTextBox.Text;
            DateTime publishDate = publishDateDateTimePicker.Value;

            this.bookTableAdapter.Insert(title, author, publishDate, null);

            MessageBox.Show("Book sold.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
