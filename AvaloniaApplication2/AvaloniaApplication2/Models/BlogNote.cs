using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication2.Models
{
    public class BlogNote
    {
        public BlogNote(string title_1, string content, List<string> tags, string imageurl = "")
        {
            Title_1 = title_1;
            Content = content;
            Image = new Bitmap(AssetLoader.Open(new Uri(imageurl)));
            Tags = tags;
        }
        public string Title_1 { get; set; }
        public string Content { get; set; }
        public Bitmap Image { get; set; }
        public List<string> Tags { get; set; }
         
    }
}
