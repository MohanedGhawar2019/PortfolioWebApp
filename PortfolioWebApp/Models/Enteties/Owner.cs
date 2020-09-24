using System.ComponentModel.DataAnnotations;

namespace PortfolioWebApp.Models.Enteties
{
    public class Owner:EntityId
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
