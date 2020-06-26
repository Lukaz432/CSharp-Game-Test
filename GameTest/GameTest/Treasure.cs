namespace GameClasses
{
    public class Treasure : Thing
    {
        private double _value;

        public Treasure(string aName, string aDescription, double aValue)
            : base(aName, aDescription)
        {
            _value = aValue;
        }

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
