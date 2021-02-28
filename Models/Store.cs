namespace TGTG.Api.Core.Models
{
    public class Store
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
        public double Distance { get; set; }
        public bool Favourited { get; set; }

        public override string ToString() => Name;
    }
}