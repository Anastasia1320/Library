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
using System.Xml.Serialization;
using System.IO;



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
            string isHeTakeBooks = Microsoft.VisualBasic.Interaction.InputBox("Хотите ли добавить пользователю книгу? \n Да/Нет");
            if (isHeTakeBooks == "Да" || isHeTakeBooks == "ДА" || isHeTakeBooks == "да")
            {
                person.TakeBook(books,isHeTakeBooks);
            }
            people.Add(person);

        }

        private void ShowPersonsButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (people.Count != 0)
            {
                dataGridView1.RowCount = people.Count;
                dataGridView1.ColumnCount = 2;
                for (int i = 0; i < people.Count; i++)
                {
                    dataGridView1[0, i].Value = people[i].name;

                    StringBuilder sb = new StringBuilder();

                    foreach (Book elementbook in people[i].takenBooks)
                    {
                        sb.AppendLine(elementbook.name + ",");
                    }
                    dataGridView1[1, i].Value = sb.ToString();

                }
            }
            else
            {
                MessageBox.Show("Пользователей не существует! Добавьте пользователя");
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Book>));
            using (var writer = new StreamWriter(@"E:\BSUIR\WindowsFormsApp2\Books.txt"))
            {
                serializer.Serialize(writer, books);
            }

            var serializer2 = new XmlSerializer(typeof(List<Person>));
            using (var writer = new StreamWriter(@"E:\BSUIR\WindowsFormsApp2\Persons.txt"))
            {
                serializer2.Serialize(writer, people);
            }
        }
    }
}
