using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class AInfo
    {
        protected string author;
        protected string name;
        protected string editorial;
        protected string datePublication;
        protected string category;
        protected int volume;
        protected int pages;

        public AInfo(string name, string author, string editorial, string datePublication, string category, int volume, int pages)
        {
            this.name = name;
            this.author = author;
            this.editorial = editorial;
            this.datePublication = datePublication;
            this.category = category;
            this.volume = volume;
            this.pages = pages;
        }

        public string Author { get; set; }
        public string Name { get; set; }
        public string Editorial { get; set; }
        public string DatePublication { get; set; }
        public string Category { get; set; }
        public int Volume { get; set; }
        public int Pages { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Editorial: " + editorial);
            Console.WriteLine("Date of publication: " + datePublication);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Pages: " + pages);
        }

    }
}
