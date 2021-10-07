using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
   public class Person
    {
        public string name;
        public List<Book> takenBooks =new List<Book>();
        public void TakeBook(List<Book> books, string isHeTakeBooks)
        {
  
            while (isHeTakeBooks=="Да")
            {
                StringBuilder sb = new StringBuilder();
                Book book = new Book();
                foreach (Book elementbook in books)
                {
                    sb.AppendLine(books.IndexOf(elementbook) + " - " + elementbook.name);
                }
                book.name = books[Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(sb.ToString() + " \n Введите id книги которую хотите выбрать"))].name;
                takenBooks.Add(book);
                isHeTakeBooks = Microsoft.VisualBasic.Interaction.InputBox(" Добавить еще одну книгу? \n Да/Нет");
            }
           

        }
    }
}
