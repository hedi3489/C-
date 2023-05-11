using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userType = userTypeComboBox.GetItemText(userTypeComboBox.SelectedItem);
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (userTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a user type.", "Invalid User Type", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (userType.ToLower() == "user")
            {
                int usersFound = (int)this.userTableAdapter.ValidateUserLogin(username, password);
                if (usersFound == 1)
                {
                    DataTable userIdDataTable = this.userTableAdapter.GetUserId(username, password);
                    DataRow userIdRow = userIdDataTable.Rows[0];

                    // select userId from row/table
                    string userIdStr = userIdRow["UserId"].ToString();
                    int userId = int.Parse(userIdStr);

                    // Display login success message
                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close login form after successful login
                    FormProvider.GetLoginForm().Hide();

                    // clear entered user details
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    userTypeComboBox.SelectedIndex = -1;

                    // Open UserForm
                    UserForm userForm = new UserForm(userId, username);
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (userType.ToLower() == "staff")
            {
                int staffFound = (int)this.staffTableAdapter.ValidateStaffLogin(username, password);
                if (staffFound == 1)
                {
                    DataTable staffIdDataTable = this.staffTableAdapter.GetStaffId(username, password);
                    DataRow staffIdRow = staffIdDataTable.Rows[0];

                    // select staffId from row/table
                    string staffIdStr = staffIdRow["StaffId"].ToString();
                    int staffId = int.Parse(staffIdStr);

                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormProvider.GetLoginForm().Hide();

                    // clear entered user details
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    userTypeComboBox.SelectedIndex = -1;

                    // Open StaffForm
                    StaffForm staffForm = new StaffForm(staffId, username);
                    staffForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //supplier
            {
                int supplierFound = (int)this.supplierTableAdapter.ValidateSupplierLogin(username, password);
                if (supplierFound == 1)
                {
                    DataTable supplierDataTable = this.supplierTableAdapter.GetSupplierId(username, password);
                    DataRow supplierIdRow = supplierDataTable.Rows[0];

                    // select supplierId from row/table
                    string supplierIdStr = supplierIdRow["SupplierId"].ToString();
                    int supplierId = int.Parse(supplierIdStr);

                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormProvider.GetLoginForm().Hide();

                    // clear entered user details
                    usernameTextBox.Clear();
                    passwordTextBox.Clear();
                    userTypeComboBox.SelectedIndex = -1;

                    // Open SupplierForm
                    SupplierForm supplierForm = new SupplierForm(supplierId, username);
                    supplierForm.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) { }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(null, null);
            }
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
