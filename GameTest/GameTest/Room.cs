namespace GameClasses
{
    public class Room : Thing
    {
        private int _n;
        private int _s;
        private int _w;
        private int _e;

        public Room(string aName, string aDescription, int aN, int aS, int aW, int anE)
            : base(aName, aDescription)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = anE;
        }


        public int N
        {
            get
            {
                return _n;
            }
            set
            {
                _n = value;
            }
        }


        public int S
        {
            get
            {
                return _s;
            }
            set
            {
                _s = value;
            }
        }

        public int W
        {
            get
            {
                return _w;
            }
            set
            {
                _w = value;
            }
        }

        public int E
        {
            get
            {
                return _e;
            }
            set
            {
                _e = value;
            }
        }
    }
}
