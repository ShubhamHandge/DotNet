using System.ComponentModel.DataAnnotations;
namespace CodeFirstExample.Models
{
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }

        public string DeptName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
