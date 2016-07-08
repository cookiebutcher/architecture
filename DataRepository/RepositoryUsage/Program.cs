using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookie.DataModel;
using Cookie.DataRepository;

namespace RepositoryUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SampleContext())
            {
                try
                {
                    var repo = new EntityFrameworkRepository<SampleContext>(context);
                    var cust = new Customer()
                    {
                        CreatedBy = "me",
                        FirstName = "huj",
                        LastName = "huj",
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now
                    };
                    repo.Create(cust);
                    var ord = new Order()
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        CreatedBy = "me",
                        Customer = cust,
                        Name = "order"
                    };
                    repo.Create(ord);
                    repo.Save();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
