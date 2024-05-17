namespace LV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product("Lamp", 200, 2.5);
            Product product2 = new Product("Oven", 18000, 50);
            Box box = new Box("Houshold Appliance");
            box.Add(product1);
            box.Add(product2);
            /*
            Console.WriteLine("Product Description:");
            Console.WriteLine(product1.Description());

            Console.WriteLine("Product Description:");
            Console.WriteLine(product2.Description());

            Console.WriteLine("Box Description:");
            Console.WriteLine(box.Description());
            */

            ShippingService shippingService = new ShippingService(5.0); 

            double productShippingCost1 = shippingService.CalculateShippingCost(product1);
            double productShippingCost2 = shippingService.CalculateShippingCost(product2);
            double boxShippingCost = shippingService.CalculateShippingCost(box);

            Console.WriteLine($"Shipping cost for product 1: {productShippingCost1}");
            Console.WriteLine($"Shipping cost for product 2: {productShippingCost2}");
            Console.WriteLine($"Shipping cost for box: {boxShippingCost}");
        }
    }
}