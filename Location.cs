namespace TGTG.Api.Core
{
    public class Location
    {
        public string Name { get; set; }
        public Coordinates Coordinates { get; set; }

        public override string ToString() => Name;
    }
}