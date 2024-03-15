using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmaraDesign1.Models
{
    public class Project
    {
        public int Id { get; set; }
        [MaxLength(100)]

        public string Name { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }

        [ForeignKey("Project")]
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
