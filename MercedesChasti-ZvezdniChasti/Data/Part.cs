namespace MercedesChasti_ZvezdniChasti.Data
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }//Fk m:1
        public Category Categories { get; set; } //m:1

        public int ModelId { get; set; } //Fk m:1
        public Model Models { get; set; } // m:1

        public string Quantity { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }// 1:m
        
    }
}
