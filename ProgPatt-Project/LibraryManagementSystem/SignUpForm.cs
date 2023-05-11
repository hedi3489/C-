using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace LibraryManagementSystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private bool NameCheck(string fullNamePar)
        {
            Regex lettersRegEx = new Regex("^[a-zA-Z -]+$");
            bool nameIsFullName = lettersRegEx.IsMatch(fullNamePar);
            return nameIsFullName;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string userType = userTypeComboBox.Text;

            // Store validity of name in variable
            bool nameIsValid = NameCheck(name);

            if (password == confirmPassword && nameIsValid)
            {
                if (userTypeComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a user type.", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (userType.ToLower() == "user")
                {
                    try
                    {
                        this.userTableAdapter.Insert(name, username, password, false);
                        MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (userType.ToLower() == "staff")
                {
                    try
                    {
                        this.staffTableAdapter.Insert(name, password, username);
                        MessageBox.Show("Staff added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        this.supplierTableAdapter.Insert(name, username, password);
                        MessageBox.Show("Supplier added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (!nameIsValid)
            {
                MessageBox.Show("Invalid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password != confirmPassword) // Check if the password equals the confirmed password
            {
                MessageBox.Show("The passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e) { }
    }
}