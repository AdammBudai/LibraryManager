using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class BookBO : AbstractBO
    {
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public long PublisherId { get; set; }
        public string PublisherName { get; set; }
        public bool Available { get; set; }
    }
}
