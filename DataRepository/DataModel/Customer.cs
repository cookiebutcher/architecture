using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Cookie.DataRepository.Interfaces;

namespace Cookie.DataModel
{
    [Table("Customers")]
    public class Customer : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Column]
        public string FirstName { get; set; }

        [Column]
        public string LastName { get; set; }

        public List<Order> Orders { get; set; }
        
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
