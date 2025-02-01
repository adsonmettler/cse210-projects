

using System.Text;

public class Order
    {
        // Attributes
        private List<Product> _products;
        private Customer _customer;

        // Constructor
        public Order(Customer customer)
        {
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            _products = new List<Product>();
        }

        // Methods
        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));
            
            _products.Add(product);
        }

        public double GetTotalPrice()
        {
            double total = _products.Sum(p => p.GetTotalCost());
            double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
            return total + shippingCost;
        }

        public string GetPackingLabel()
        {
            StringBuilder label = new StringBuilder("Packing Label:\n");
            foreach (var product in _products)
            {
                label.AppendLine($"Name: {product.Name}");
                label.AppendLine($"ID: {product.ProductId}");
                label.AppendLine($"Price: {product.PricePerUnit:C} each");
                label.AppendLine($"Quantity: {product.Quantity}");
                label.AppendLine("----------------------");
            }
            return label.ToString();
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
        }
    }