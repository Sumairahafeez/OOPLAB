using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.BL
{
    internal class Book
    {
        private string Name;
        private int Volumes;
       
        public Book(string name, int volumes)
        {   
            SetName(name);
            SetVolume(volumes);
            
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetVolume(int volume)
        {
            this.Volumes = volume;
        }
        public int GetVolume()
        {
            return Volumes;
        }
       
    }
}
