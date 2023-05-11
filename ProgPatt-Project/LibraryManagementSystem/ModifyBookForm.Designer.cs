namespace LibraryManagementSystem
{
    partial class ModifyBookForm
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
            this.libraryDatabaseDataSet = new LibraryManagementSystem.LibraryDatabaseDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookIdTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.modifyButton = new System.Windows.Forms.Button();
            bookIdLabel = new System.Windows.Forms.Label();
            bookTitleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookIdLabel
            // 
            bookIdLabel.AutoSize = true;
            bookIdLabel.Location = new System.Drawing.Point(67, 50);
            bookIdLabel.Name = "bookIdLabel";
            bookIdLabel.Size = new System.Drawing.Size(47, 13);
            bookIdLabel.TabIndex = 1;
            bookIdLabel.Text = "Book Id:";
            // 
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Location = new System.Drawing.Point(56, 88);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new System.Drawing.Size(58, 13);
            bookTitleLabel.TabIndex = 2;
            bookTitleLabel.Text = "Book Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(73, 124);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(41, 13);
            authorLabel.TabIndex = 4;
            authorLabel.Text = "Author:";
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Location = new System.Drawing.Point(44, 163);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(70, 13);
            publishDateLabel.TabIndex = 6;
            publishDateLabel.Text = "Publish Date:";
            // 
            // libraryDatabaseDataSet
            // 
            this.libraryDatabaseDataSet.DataSetName = "LibraryDatabaseDataSet";
            this.libraryDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDatabaseDataSet;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = this.bookTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // bookIdTextBox
            // 
            this.bookIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookId", true));
            this.bookIdTextBox.Location = new System.Drawing.Point(120, 47);
            this.bookIdTextBox.Name = "bookIdTextBox";
            this.bookIdTextBox.ReadOnly = true;
            this.bookIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookIdTextBox.TabIndex = 2;
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookTitle", true));
            this.bookTitleTextBox.Location = new System.Drawing.Point(120, 85);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(200, 20);
            this.bookTitleTextBox.TabIndex = 3;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(120, 121);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(200, 20);
            this.authorTextBox.TabIndex = 5;
            // 
            // publishDateDateTimePicker
            // 
            this.publishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.publishDateDateTimePicker.Location = new System.Drawing.Point(120, 159);
            this.publishDateDateTimePicker.Name = "publishDateDateTimePicker";
            this.publishDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.publishDateDateTimePicker.TabIndex = 7;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(142, 218);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 8;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // ModifyBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 272);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.publishDateDateTimePicker);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(bookTitleLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(bookIdLabel);
            this.Controls.Add(this.bookIdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModifyBookForm";
            this.Text = "ModifyBookForm";
            this.Load += new System.EventHandler(this.ModifyBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDatabaseDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bookIdTextBox;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker publishDateDateTimePicker;
        private System.Windows.Forms.Button modifyButton;
    }
}