using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities {
    public class CustomerEntity {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; } = null!;
    }

}
