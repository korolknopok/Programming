namespace Programming.Model
{
    public class Song
    {
        private int _durationSeconds;

        public Song()
        {
        }

        public Song(string musician,
            string name,
            int durationSeconds)
        {
            Musician = musician;
            Name = name;
            DurationSeconds = durationSeconds;
        }

        public string Musician { get; set; }
        public string Name { get; set; }

        public int DurationSeconds
        {
            get { return _durationSeconds; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }

                _durationSeconds = value;
            }
        }
    }
}