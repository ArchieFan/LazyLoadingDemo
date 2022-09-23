using LazyLoadingDemo.Models;

namespace LazyLoading
{
    class Program
    {
        static void Main()
        {
            // customer + Order will be loaded
            Customer c = new Customer();    
            Console.WriteLine(c.CustomerName);
            foreach (var oitem in c.Orders)
            {
                Console.WriteLine(oitem.OrderNumber);
            }
        }
    }


}