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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(23, 52);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(150, 23);
            this.AddBookButton.TabIndex = 0;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(179, 53);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(150, 23);
            this.AddPersonButton.TabIndex = 1;
            this.AddPersonButton.Text = "Добавить пользователя";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 378);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShowPersonsButton
            // 
            this.ShowPersonsButton.Location = new System.Drawing.Point(179, 82);
            this.ShowPersonsButton.Name = "ShowPersonsButton";
            this.ShowPersonsButton.Size = new System.Drawing.Size(150, 23);
            this.ShowPersonsButton.TabIndex = 3;
            this.ShowPersonsButton.Text = "Пользователи";
            this.ShowPersonsButton.UseVisualStyleBackColor = true;
            this.ShowPersonsButton.Click += new System.EventHandler(this.ShowPersonsButton_Click);
            // 
            // ShowAllBooksButton
            // 
            this.ShowAllBooksButton.Location = new System.Drawing.Point(23, 81);
            this.ShowAllBooksButton.Name = "ShowAllBooksButton";
            this.ShowAllBooksButton.Size = new System.Drawing.Size(150, 23);
            this.ShowAllBooksButton.TabIndex = 4;
            this.ShowAllBooksButton.Text = "Книги";
            this.ShowAllBooksButton.UseVisualStyleBackColor = true;
            this.ShowAllBooksButton.Click += new System.EventHandler(this.ShowAllBooksButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(357, 67);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(85, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(329, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Учёт книг";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowPersonsButton;
        private System.Windows.Forms.Button ShowAllBooksButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
    }
}

