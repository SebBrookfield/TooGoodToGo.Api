namespace TGTG.Api.Core.Models
{
    public class Location
    {
        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }

        public override string ToString() => Name;
    }
}