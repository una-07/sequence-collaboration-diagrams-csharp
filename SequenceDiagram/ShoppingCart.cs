using System.Collections.Generic;
using System.Linq;

public class ShoppingCart
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotal()
    {
        return Products.Sum(p => p.Price);
    }
}
