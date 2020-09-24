using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioWebApp.Models.Enteties
{
    public class Photographer:EntityId
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime dateTime { get; set; }
    }
}
