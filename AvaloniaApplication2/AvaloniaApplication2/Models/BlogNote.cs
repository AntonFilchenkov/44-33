using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Models
{
    public class BlogNote
    {
        public BlogNote(string title_1, string content, string imageurl = "")
        {
            Title_1 = title_1;
            Content = content;
            ImageURL = imageurl;
        }
        public string Title_1 { get; set; }
        public string Content { get; set; }
        public string ImageURL { get; set; }
    }
}
