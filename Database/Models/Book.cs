using Manager.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public partial class Book : IEntity<long>
    {        
        public long Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("AuthorId")]
        public long AuthorId { get; set; }
        [ForeignKey("PublisherId")]
        public long PublisherId { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public bool Available { get; set; }
    }
}
