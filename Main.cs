using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        List<Book> books = new List<Book>();
        List<Person> people = new List<Person>();
        public Main()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            
            Book book = new Book();
            book.name = Microsoft.VisualBasic.Interaction.InputBox("Введите название книги");
            books.Add(book);
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.name = Microsoft.VisualBasic.Interaction.InputBox("Введите имя");
            string isHeTakeBooks = Microsoft.VisualBasic.Interaction.InputBox("Человек имеет книги? \n Да/Нет");
            if (isHeTakeBooks == "Да")
            {
                person.TakeBook(books,isHeTakeBooks);
            }
            people.Add(person);

        }

        private void ShowPersonsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = people.Count;
            dataGridView1.ColumnCount = 2;
            for (int i = 0; i < people.Count; i++)
            {
                dataGridView1[0, i].Value = people[i].name;

                StringBuilder sb = new StringBuilder();
            
                foreach (Book elementbook in people[i].takenBooks)
                {
                    sb.AppendLine(elementbook.name);
                }
                dataGridView1[1, i].Value =sb.ToString();
              
            }
        }

        private void ShowAllBooksButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = books.Count;
            dataGridView1.ColumnCount = 1;
            for (int i = 0; i < books.Count; i++)
            {
                dataGridView1[0, i].Value = books[i].name;
 
            }
        }
    }
}
