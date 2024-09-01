using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManager.Models;

namespace LibraryManager.Models
{
    public class BorrowingsBO : AbstractBO
    {
        public DateTime BorrowDate { get; set; }
        public long UserId { get; set; }
        public long BookId { get; set; }
    }
}
