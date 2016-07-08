using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookie.DataRepository.Interfaces;

namespace Cookie.DataModel
{
    [Table("Orders")]
    public class Order : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [Column]
        public DateTime CreatedDate { get; set; }

        [Column]
        public string CreatedBy { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        [Column]
        public string ModifiedBy { get; set; }
    }
}
