using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDataRepository
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
    }
}
