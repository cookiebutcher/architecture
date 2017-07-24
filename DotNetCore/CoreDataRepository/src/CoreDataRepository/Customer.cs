using System.Collections.Generic;

namespace CoreDataRepository
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Order> Orders { get; set; }
    }
}
