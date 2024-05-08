internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ItemForSale lawnturf = new ItemForSale("lawn turf", 20.95);
        lawnturf.setDiscount(34);
        Console.WriteLine(lawnturf.calculatePrice());
    }
}
public class ItemForSale
{
    private string itemName;
    private double price;
    private double discount;
    public static int stockCount;
    public ItemForSale (string newName, double newPrice)
    {
        this.itemName = newName;
        this.price = newPrice;
        this.discount = 0;
        stockCount++;
    }
    public string getItemName()
    {
        return itemName;
    }
    public void setItemName(string newName)
    {
        itemName = newName;
    }
    public double getDiscount()
    {
        return discount;
    }
    public void setDiscount(double newDiscount)
    {
        if (discount < 0)
        {
            Console.WriteLine("Discount out of range, must be from 0 to 50.");
        }
        else if (discount > 50)
        {
            Console.WriteLine("Discount out of range, must be from 0 to 50.");
        }
        else
        {
            discount = newDiscount;
        }
    }
    public double calculatePrice()
    {
        double newPrice = price - (price * (discount / 100));
        return newPrice;
    }
}