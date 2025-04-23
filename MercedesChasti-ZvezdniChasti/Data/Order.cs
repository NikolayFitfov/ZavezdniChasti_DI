using System.Net.Http.Headers;

namespace MercedesChasti_ZvezdniChasti.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public User Users {  get; set; }
        public int PartId { get; set; }
        public Part Parts { get; set; } // m:1
        public decimal Quantity {  get; set; }

        public DateTime DateRegister { get; set; }
    }
}
