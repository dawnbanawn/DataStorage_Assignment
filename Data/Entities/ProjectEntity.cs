using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities {
    public class ProjectEntity {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "date")]

        public DateTime EndDate { get; set; }

        // Connections to other entities

        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; } = null!;

        public int StatusId { get; set; }
        public StatusTypeEntity Status { get; set; } = null!;

        public int UserId { get; set; }
        public CustomerEntity User { get; set; } = null!;

        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;


    }
}
