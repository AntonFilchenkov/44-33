using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Models
{
    public class Article
    {
        public Article(string title_1, string publicationDate)
        {
            Title_1 = title_1;
            PublicationDate = publicationDate;
        }

        public string Title_1 { get; set; }
        public string PublicationDate { get; set; }
    }
   
}
