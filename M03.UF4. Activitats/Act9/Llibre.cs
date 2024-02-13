using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Llibre : AInfo
    {
        private string isbn;
        private string language;
        private string format;
        private bool isPrestat;
        private bool isSecondHand;

        public Llibre(string name, string author, string editorial, string datePublication, string category, int volume, int pages, string isbn, string language, string format, bool isPrestat, bool isSecondHand) : base(name, author, editorial, datePublication, category, volume, pages)
        {
            this.isbn = isbn;
            this.language = language;
            this.format = format;
            this.isPrestat = isPrestat;
            this.isSecondHand = isSecondHand;
        }

        public string Isbn { get; set; }
        public string Language { get; set; }
        public string Format { get; set; }
        public bool IsPrestat { get; set; }
        public bool IsSecondHand { get; set; }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Language: " + language);
            Console.WriteLine("Format: " + format);
        }

        public void Prestar()
        {
            if (isPrestat)
            {
                Console.WriteLine("The book is already borrowed");
            }
            else
            {
                isPrestat = true;
                Console.WriteLine("The book has been borrowed");
            }
        }

        public void Return()
        {
            if (isPrestat)
            {
                isPrestat = false;
                Console.WriteLine("The book has been returned");
            }
            else
            {
                Console.WriteLine("The book is not borrowed");
            }
        }

        public bool IsSecond()
        {
            return isSecondHand;
        }


    }
}
