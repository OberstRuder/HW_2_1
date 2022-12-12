namespace HW_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of available products:");
            Goods.GoodList();
            Console.WriteLine("Select products by entering numbers separated by space (max 10)");
            Cart.CartReader();
            Customers.NewCustomer();
            Order.OrderProcess();
        }
    }
}
