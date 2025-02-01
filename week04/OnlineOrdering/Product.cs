

public class Product
    {
        // Attributes
        private string _name;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;

        // Constructor
        public Product(string name, string productId, double pricePerUnit, int quantity)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(productId))
                throw new ArgumentException("Product name and ID cannot be empty.");
            if (pricePerUnit <= 0)
                throw new ArgumentException("Price per unit must be greater than zero.");
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be at least 1.");

            _name = name;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        // Getters and Setters
        public string Name => _name;
        public string ProductId => _productId;
        public double PricePerUnit => _pricePerUnit;
        public int Quantity => _quantity;

        //Method
        public double GetTotalCost() => _pricePerUnit * _quantity;
    }