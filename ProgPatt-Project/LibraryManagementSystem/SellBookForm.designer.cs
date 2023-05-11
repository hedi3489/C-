namespace LibraryManagementSystem
{
    partial class SellBookForm
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
            System.Windows.Forms.Label bookTitleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publishDateLabel;
            this.SellBookLabel = new System.Windows.Forms.Label();
            this.sellBookButton = new System.Windows.Forms.Button();
            this.libraryDatabaseDataSet = new LibraryManagementSystem.LibraryDatabaseDataSet();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.BookTableAdapter();
            this.tableAdapterManager = new LibraryManagementSystem.LibraryDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publishDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            bookTitleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publishDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SellBookLabel
            // 
            this.SellBookLabel.Font = new System.Drawing.Font("Yu Gothic UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellBookLabel.Location = new System.Drawing.Point(112, 11);
            this.SellBookLabel.Name = "SellBookLabel";
            this.SellBookLabel.Size = new System.Drawing.Size(165, 43);
            this.SellBookLabel.TabIndex = 13;
            this.SellBookLabel.Text = "SELL BOOK";
            this.SellBookLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellBookButton
            // 
            this.sellBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellBookButton.Location = new System.Drawing.Point(132, 287);
            this.sellBookButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellBookButton.Name = "sellBookButton";
            this.sellBookButton.Size = new System.Drawing.Size(127, 42);
            this.sellBookButton.TabIndex = 25;
            this.sellBookButton.Text = "Sell Book";
            this.sellBookButton.UseVisualStyleBackColor = true;
            this.sellBookButton.Click += new System.EventHandler(this.sellBookButton_Click);
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
            // bookTitleLabel
            // 
            bookTitleLabel.AutoSize = true;
            bookTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            bookTitleLabel.Location = new System.Drawing.Point(31, 70);
            bookTitleLabel.Name = "bookTitleLabel";
            bookTitleLabel.Size = new System.Drawing.Size(89, 20);
            bookTitleLabel.TabIndex = 26;
            bookTitleLabel.Text = "Book Title:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "BookTitle", true));
            this.bookTitleTextBox.Location = new System.Drawing.Point(35, 94);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(321, 22);
            this.bookTitleTextBox.TabIndex = 27;
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            authorLabel.Location = new System.Drawing.Point(31, 142);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(63, 20);
            authorLabel.TabIndex = 27;
            authorLabel.Text = "Author:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(35, 165);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(321, 22);
            this.authorTextBox.TabIndex = 28;
            // 
            // publishDateLabel
            // 
            publishDateLabel.AutoSize = true;
            publishDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            publishDateLabel.Location = new System.Drawing.Point(31, 218);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new System.Drawing.Size(110, 20);
            publishDateLabel.TabIndex = 28;
            publishDateLabel.Text = "Publish Date:";
            // 
            // publishDateDateTimePicker
            // 
            this.publishDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "PublishDate", true));
            this.publishDateDateTimePicker.Location = new System.Drawing.Point(35, 242);
            this.publishDateDateTimePicker.Name = "publishDateDateTimePicker";
            this.publishDateDateTimePicker.Size = new System.Drawing.Size(321, 22);
            this.publishDateDateTimePicker.TabIndex = 29;
            // 
            // SellBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 350);
            this.Controls.Add(publishDateLabel);
            this.Controls.Add(this.publishDateDateTimePicker);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(bookTitleLabel);
            this.Controls.Add(this.bookTitleTextBox);
            this.Controls.Add(this.sellBookButton);
            this.Controls.Add(this.SellBookLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SellBookForm";
            this.Text = "Sell Book";
            this.Load += new System.EventHandler(this.SellBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SellBookLabel;
        private System.Windows.Forms.Button sellBookButton;
        private LibraryDatabaseDataSet libraryDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDatabaseDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.DateTimePicker publishDateDateTimePicker;
    }
}