using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObjects
{
    public class BorrowingsDTO
    {
        public long Id { get; set; }
        public long BookId { get; set; }
        public long UserId { get; set; }
        public DateTime BorrowDate { get; set; }

        public class Create
        {
            public long BookId { get; set; }
            public long UserId { get; set; }
            public DateTime BorrowDate { get; set; }
        }

        public class Update
        {
            public DateTime BorrowDate { get; set; }
        }
    }
}
