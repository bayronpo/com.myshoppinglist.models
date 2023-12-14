
using Microsoft.AspNetCore.Identity;

namespace com.myshoppinglist.models
{
    public class User : IdentityUser
    {
        public ICollection<ShoppingList>? ShoppingLists { get; set; }
    }
}
