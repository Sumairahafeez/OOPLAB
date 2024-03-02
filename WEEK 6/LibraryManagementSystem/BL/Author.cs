using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BL
{
    internal class Author
    {
        private string Name;
        private string Gender;
        private string Email;
        private List<Book> BooksWritten;
        public Author() { }
        public Author(string name, string gender, string email)
        {
            SetName(name);
            SetGender(gender);
            SetEmail(email);
            BooksWritten = new List<Book>();
           
        }

        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
           this.Name = Name;
        }
        public string GetGender()
        {
            return Gender;
        }
        public bool SetGender(string gender)
        {   if (gender == "Female" || gender == "female" || gender == "Male" || gender == "male" || gender == "Other")
            {
                Gender = gender;
                return true; 
            }
        return false;
        }
        public string GetEmail()
        {
            return Email;
        }
        public bool SetEmail(string Mail)
        {
            for(int i = 0; i<Mail.Length; i++)
            {
                if (Mail.Contains('@'))
                {
                    Email = Mail;
                    return true;
                }
            }
            return false;
        }
        public void AddBooks(string name, int volume)
        {
            Book B = new Book(name, volume);
            BooksWritten.Add(B);
        }
        public int GetBooksListCount()
        {
            return BooksWritten.Count;
        }
        public string GetBook(int index)
        {
            return BooksWritten[index].GetName();
        }
    }
}
