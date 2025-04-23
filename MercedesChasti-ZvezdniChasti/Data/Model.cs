namespace MercedesChasti_ZvezdniChasti.Data
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
