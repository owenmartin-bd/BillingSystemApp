namespace BillingSystemApp.DBContext
{
    public class OpeningInvoice
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string? LinkServiceId { get; set; }
        public DateTime BillingStartDate { get; set; }
        public DateTime BillingEndDate { get; set; }
        public int BillingDurationDays { get; set; }
        public int DaysInMonths { get; set; }
        public int BillingYear { get; set; }
        public int BillingMonth { get; set; }
        public decimal CapacityQty { get; set; }
        public decimal Rate { get; set; }
        public decimal BillAmount { get; set; }
    }
}
