using System.ComponentModel.DataAnnotations.Schema;

namespace EmaraDesign1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public string? Address { get; set; }
        public string? Image { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department? Department { get; set; }
    }
}
