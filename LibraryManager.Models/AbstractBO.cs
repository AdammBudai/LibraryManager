using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Helpers;

namespace LibraryManager.Models
{
    public abstract class AbstractBO 
    {
        public long Id { get; set; }
        [NotMapped]
        public IEntity<long> Model { get; set; }
    }
}
