using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingDemo.Models
{
    public class Customer
    {
        private Lazy<List<Order>> _orders = null;

        public List<Order> Orders
        {
            get {
                // Add below for lazy loading
                //if (_orders == null)
                //{
                //    _orders = new List<Order>();
                //}
                return _orders.Value; 
            }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public Customer()
        {
            // Makes a database trip
            _customerName = "Archie Fan";
            // remove for lazy loading
            //_orders = LoadOrders();
            _orders = new Lazy<List<Order>>(() => LoadOrders());
        }

        private List<Order> LoadOrders()
        {
            List<Order> temp = new List<Order>();
            Order o = new Order();
            o.OrderNumber = "ord1001";
            temp.Add(o);
            o = new Order();
            o.OrderNumber = "ord1002";
            temp.Add(o);
            return temp;
        }
    }
}
