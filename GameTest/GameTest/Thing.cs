namespace GameClasses
{
    public class Thing
    {
        private string _name;
        private string _description;

        public Thing(string aName, string aDescription)
        {
            _name = aName;
            _description = aDescription;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
