using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Manager.Helpers;

namespace Database.Models
{
    public partial class Borrowings : IEntity<long>
    {
        public long Id { get; set; }
        [ForeignKey("BookId")]
        public long BookId { get; set; }
        [ForeignKey("UserId")]
        public long UserId { get; set; }
        public DateTime BorrowDate { get; set; }
    }
}
