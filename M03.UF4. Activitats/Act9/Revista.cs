using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Revista : AInfo
    {
        private string issn;
        private string language;
        private string format;

        public Revista(string name, string author, string editorial, string datePublication, string category, int volume, int pages, string issn, string language, string format) : base(name, author, editorial, datePublication, category, volume, pages)
        {
            this.issn = issn;
            this.language = language;
            this.format = format;
        }

        public string Issn { get; set; }
        public string Language { get; set; }
        public string Format { get; set; }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ISSN: " + issn);
            Console.WriteLine("Language: " + language);
            Console.WriteLine("Format: " + format);
        }

        public void Prestar()
        {
            Console.WriteLine("The magazine cannot be borrowed");
        }

        public void Return()
        {
            Console.WriteLine("The magazine cannot be returned");
        }

    }
}
