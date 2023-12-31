﻿namespace com.myshoppinglist.models
{
    public class Item
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public required string Name { get; set; }
        public Guid ShoppingListId { get; set; }
        public required ShoppingList ShoppingList { get; set; }
    }
}
