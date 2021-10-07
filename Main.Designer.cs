namespace WindowsFormsApp2
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowPersonsButton = new System.Windows.Forms.Button();
            this.ShowAllBooksButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(23, 26);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(85, 23);
            this.AddBookButton.TabIndex = 0;
            this.AddBookButton.Text = "Add book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(23, 65);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(85, 23);
            this.AddPersonButton.TabIndex = 1;
            this.AddPersonButton.Text = "Add Person";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(142, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 388);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShowPersonsButton
            // 
            this.ShowPersonsButton.Location = new System.Drawing.Point(23, 94);
            this.ShowPersonsButton.Name = "ShowPersonsButton";
            this.ShowPersonsButton.Size = new System.Drawing.Size(85, 23);
            this.ShowPersonsButton.TabIndex = 3;
            this.ShowPersonsButton.Text = "Show Persons";
            this.ShowPersonsButton.UseVisualStyleBackColor = true;
            this.ShowPersonsButton.Click += new System.EventHandler(this.ShowPersonsButton_Click);
            // 
            // ShowAllBooksButton
            // 
            this.ShowAllBooksButton.Location = new System.Drawing.Point(23, 134);
            this.ShowAllBooksButton.Name = "ShowAllBooksButton";
            this.ShowAllBooksButton.Size = new System.Drawing.Size(85, 23);
            this.ShowAllBooksButton.TabIndex = 4;
            this.ShowAllBooksButton.Text = "Show Books";
            this.ShowAllBooksButton.UseVisualStyleBackColor = true;
            this.ShowAllBooksButton.Click += new System.EventHandler(this.ShowAllBooksButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(23, 172);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ShowAllBooksButton);
            this.Controls.Add(this.ShowPersonsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.AddBookButton);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowPersonsButton;
        private System.Windows.Forms.Button ShowAllBooksButton;
        private System.Windows.Forms.Button SaveButton;
    }
}

