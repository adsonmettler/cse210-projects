

// Class to store comment information
    public class Comments
    {
        private string _name;
        private string _textcomment;

        // Constructor
        public Comments(string name, string textcomment)
        {
            _name = name;
            _textcomment = textcomment;
        }

        // (Getters and Setters)
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string TextComment
        {
            get { return _textcomment; }
            set { _textcomment = value; }
        }
    }