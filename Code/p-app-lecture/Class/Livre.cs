using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_app_lecture.Class
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public byte[] EpubFile { get; set; }
        public string Summary { get; set; }
        public int YearPublished { get; set; }
        public byte[] CoverImage { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
