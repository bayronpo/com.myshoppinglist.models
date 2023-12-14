namespace com.myshoppinglist.models
{
    public class Item(string name)
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; } = name;
    }
}
