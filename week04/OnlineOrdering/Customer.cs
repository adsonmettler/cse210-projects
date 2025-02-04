

public class Customer
    {
        // Attributes
        private string _name;
        private Address _address;

        // Constructor
        public Customer(string name, Address address)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Customer name cannot be empty.");
            
            _name = name;
            _address = address ?? throw new ArgumentNullException(nameof(address));
        }

        // Getters and Setters
        public string Name => _name;
        public Address Address => _address;

        // Method
        public bool LivesInUSA() => _address.IsInUSA();
    }