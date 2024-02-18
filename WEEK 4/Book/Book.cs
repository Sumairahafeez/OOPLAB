using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
        public List<string> chapters;
        public int bookMarks;
        public int price;
        public bool isAvailable;
        public bool isTheBookAvailable()
        { 
            return isAvailable; 
        }
        public string getChapter(int chapterNumber)
        {
            for(int i = 0; i < chapters.Count; i++) 
            {
                if(chapterNumber == i)
                {
                    return chapters[i];
                }
            }
            return null;
        }
        public int getBookMark()
        {
            return bookMarks;
        }
    }
}
