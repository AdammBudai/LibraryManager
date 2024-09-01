using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObjects
{
    public class BookDTO
    { 
        public long Id { get; set; }
        public string Title { get; set; }
        public long AuthorId { get; set; }
        public long PublisherId { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public bool Available { get; set; } = true;

        public class Create
        {
            public string Title { get; set; }
            public string AuthorName { get; set; }
            public long? AuthorId { get; set; }
            public string PublisherName { get; set; }
            public long? PublisherId { get; set; }
            public DateTime PublishDate { get; set; }
            public string ISBN { get; set; }
            public bool Available { get; set; } = true;
        }

        public class Update
        {
            public string? Title { get; set; }
            public DateTime? PublishDate { get; set; }
            public string? ISBN { get; set; }
            public bool? Available { get; set; }
        }
    }
}
