namespace TGTG.Api.Core
{
    public class Order
    {
        public string OrderId { get; set; }
        public string ReceiptId { get; set; }
        public string State { get; set; }
        public TimeFrame PickupTimeFrame { get; set; }

        protected internal Order()
        {
        }
    }
}