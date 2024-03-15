using System.ComponentModel.DataAnnotations;

namespace EmaraDesign1.Models
{
    public class Client
    {
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }

        public string number { get; set; }

        public virtual List<Project>? projects { get; set; }
    }
}
