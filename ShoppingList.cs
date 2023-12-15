namespace com.myshoppinglist.models
{
    public class ShoppingList
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string? Name { get; set; }
        public List<Item>? Items { get; set; }
        public Guid UserId { get; set; }
        public required User User { get; set; }
    }
}
