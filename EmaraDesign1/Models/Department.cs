using System.ComponentModel.DataAnnotations;

namespace EmaraDesign1.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(100)]

        public string Name { get; set; }
        public string? ManagerName { get; set; }
        public virtual List<Employee>? Employees { get; set; }
    }
}
