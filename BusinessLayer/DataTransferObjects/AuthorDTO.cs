using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BusinessLayer.DataTransferObjects
{
    public class AuthorDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        [JsonIgnore]
        public ICollection<Book>? Books { get; set; }

        public class Create
        {
            public string Name { get; set; }
            public string? Email { get; set; }
        }

        public class Update
        {
            public string? Name { get; set; }
            public string? Email { get; set; }
        }
    }
}
