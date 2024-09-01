using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Manager.Helpers;

namespace Database.Models
{
    public partial class Author : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
    }
}
