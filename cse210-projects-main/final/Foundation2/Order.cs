public class Order
{
    private List<Product> products;
    Custumer costumer;

    public Order(Custumer costumer)
    {
        this.costumer = costumer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public string ComputeTotalPrice()
    {
        double total = 0;

        foreach (Product product in products)
        {
            total += product.ComputeTotalCost();
        }
        if (costumer.IsInUSA())
        {
        total += 5;
        }
        else{
            total += 35;
        }
        return total + "\n";
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += product.GetProductName() + $"({product.GetProductId()})" + " - " + product.GetQuantity() + "\n";
        }
        return $"Packing Label:\n{packingLabel}";
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName: {costumer.GetName()}\nAdress:{costumer.GetAdress()}\n";
    }
}