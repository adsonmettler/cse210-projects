


public class Address
    {
        // Attributes
        private string _street;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        // Constructor
        public Address(string street, string city, string stateOrProvince, string country)
        {
            _street = street ?? throw new ArgumentNullException(nameof(street));
            _city = city ?? throw new ArgumentNullException(nameof(city));
            _stateOrProvince = stateOrProvince ?? throw new ArgumentNullException(nameof(stateOrProvince));
            _country = country ?? throw new ArgumentNullException(nameof(country));
        }

        // Getter and Setters
        public string Street => _street;
        public string City => _city;
        public string StateOrProvince => _stateOrProvince;
        public string Country => _country;

        // Methods
        public bool IsInUSA() => _country.ToUpper() == "USA";

        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_stateOrProvince}\n{_country}";
        }
    }







