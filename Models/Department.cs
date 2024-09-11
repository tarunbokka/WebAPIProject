using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebAPIProject.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string ? DName { get; set; }
        public string ? Location { get; set; }

        public ICollection<Employee>  Employees { get; set; }

    }
}
