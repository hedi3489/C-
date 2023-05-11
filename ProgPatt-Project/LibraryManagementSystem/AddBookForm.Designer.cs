namespace LibraryManagementSystem
{
    partial class AddBookForm
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
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.AddBookLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.addBookButton = new System.Windows.Forms.Button();
            this.publishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.libraryDatabaseDataSet = new LibraryManagementSystem.LibraryDatabaseDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.Location = new System.Drawing.Point(23, 57);
            this.bookTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(75, 17);
            this.bookTitleLabel.TabIndex = 11;
            this.bookTitleLabel.Text = "Book Title:";
            // 
            // AddBookLabel
            // 
            this.AddBookLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookLabel.Location = new System.Drawing.Point(84, 9);
            this.AddBookLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddBookLabel.Name = "AddBookLabel";
            this.AddBookLabel.Size = new System.Drawing.Size(124, 35);
            this.AddBookLabel.TabIndex = 12;
            this.AddBookLabel.Text = "ADD BOOK";
            this.AddBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(23, 115);
            this.authorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(54, 17);
            this.authorLabel.TabIndex = 13;
            this.authorLabel.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Publish date:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleTextBox.Location = new System.Drawing.Point(26, 76);
            this.bookTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(242, 23);
            this.bookTitleTextBox.TabIndex = 15;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(26, 134);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(242, 23);
            this.authorTextBox.TabIndex = 16;
            // 
            // addBookButton
            // 
            this.addBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(99, 233);
            this.addBookButton.Margin = new System.Windows.Forms.Padding(2);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(95, 34);
            this.addBookButton.TabIndex = 18;
            this.addBookButton.Text = "Add Book";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // publishDateDateTimePicker
            // 
            this.publishDateDateTimePicker.Location = new System.Drawing.Point(26, 197);
            this.publishDateDateTimePicker.Name = "publishDateDateTimePicker";
            this.publishDateDateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.publishDateDateTimePicker.TabIndex = 19;
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
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 284);
            this.Controls.Add(this.publishDateDateTimePicker);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.AddBookLabel);
            this.Controls.Add(this.bookTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.Label AddBookLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.DateTimePicker publishDateDateTimePicker;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDatabaseDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}