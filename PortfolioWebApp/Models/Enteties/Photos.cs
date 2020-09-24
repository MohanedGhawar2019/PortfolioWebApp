using System;

namespace PortfolioWebApp.Models.Enteties
{
    public class Photos:EntityId
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public byte[] DataFile { get; set; }
        public Photographer photographer { get; set; }
    }
}
