using Microsoft.EntityFrameworkCore;
using WebAPIProject.Models;

namespace WebAPIProject.DatabaseContext
{
    public class DBContextPro : DbContext
    {
        public DBContextPro(DbContextOptions<DBContextPro> options) : base(options) { }
        
        public Dbset<Department> Department { get; set; }

        public Dbset<Employee> Employees { get; set; }

    }
}
