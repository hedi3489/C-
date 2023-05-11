namespace Lend_Book
{
    partial class LendBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bookIdLabel;
            System.Windows.Forms.Label bookTitleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publishDateLabel;
            this.userIdLabel = new System.Windows.Forms.Label();
            this.LendButton = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDatabaseDataSet = new LibraryManagementSystem.LibraryDatabaseDataSet();
            this.userTableAdapter = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookTableAdapter = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.BookTableAdapter();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            bookIdLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new System.Drawing.Point(35, 41);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(47, 13);
            bookIdLabel.TabIndex = 5;
            bookIdLabel.Text = "Book Id:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Location = new System.Drawing.Point(24, 67);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new System.Drawing.Size(58, 13);
            bookTitleLabel.TabIndex = 6;
            bookTitleLabel.Text = "Book Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(41, 93);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 13);
            authorLabel.TabIndex = 7;
            authorLabel.Text = "Author:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(12, 120);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(70, 13);
            publishDateLabel.TabIndex = 9;
            publishDateLabel.Text = "Publish Date:";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(296, 23);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(102, 17);
            this.userIdLabel.TabIndex = 2;
            this.userIdLabel.Text = "Select User ID:";
            // 
            // LendButton
            // 
            this.LendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendButton.Location = new System.Drawing.Point(181, 165);
            this.LendButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LendButton.Name = "LendButton";
            this.LendButton.Size = new System.Drawing.Size(84, 29);
            this.LendButton.TabIndex = 4;
            this.LendButton.Text = "Lend";
            this.LendButton.UseVisualStyleBackColor = true;
            this.LendButton.Click += new System.EventHandler(this.LendButton_Click);
            // 
            // userListBox
            // 
            this.userListBox.DataSource = this.userBindingSource;
            this.userListBox.DisplayMember = "UserId";
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(299, 41);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(120, 95);
            this.userListBox.TabIndex = 5;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookId", true));
            this.bookIdTextBox.Location = new System.Drawing.Point(82, 38);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.ReadOnly = true;
            this.bookIdTextBox.Size = new System.Drawing.Size(183, 20);
            this.bookIdTextBox.TabIndex = 6;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookTitle", true));
            this.bookTitleTextBox.Location = new System.Drawing.Point(82, 64);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.ReadOnly = true;
            this.bookTitleTextBox.Size = new System.Drawing.Size(183, 20);
            this.bookTitleTextBox.TabIndex = 7;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(82, 90);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(183, 20);
            this.authorTextBox.TabIndex = 8;
            // 
            // publishDateDateTimePicker
            // 
            this.publishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.publishDateDateTimePicker.Enabled = false;
            this.publishDateDateTimePicker.Location = new System.Drawing.Point(82, 116);
            this.publishDateDateTimePicker.Name = "publishDateDateTimePicker";
            this.publishDateDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.publishDateDateTimePicker.TabIndex = 10;
            // 
            // LendBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 220);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.publishDateDateTimePicker);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(bookTitleLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(bookIdLabel);
            this.Controls.Add(this.bookIdTextBox);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.LendButton);
            this.Controls.Add(this.userIdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LendBookForm";
            this.Text = "Lend Book";
            this.Load += new System.EventHandler(this.LendBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Button LendButton;
        private System.Windows.Forms.ListBox userListBox;
        private LibraryManagementSystem.LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker publishDateDateTimePicker;
    }
}

