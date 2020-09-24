using System.ComponentModel.DataAnnotations;

namespace PortfolioWebApp.Models.Enteties
{
    public class Contact:EntityId
    {
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Facebook { get; set; }
        [Required]
        public string Twitter { get; set; }
        [Required]
        public string Instagram { get; set; }
    }
}
