namespace Programming.Model
{
    public class Discipline
    {
        private int _mark;

        public Discipline()
        {
        }

        public Discipline(string name,
            string examDate,
            int mark)
        {
            Name = name;
            ExamDate = examDate;
            Mark = mark;
        }

        public string Name { get; set; }
        public string ExamDate { get; set; }

        public int Mark
        {
            get { return _mark; }
            set
            {
                if (1 > value || value > 5)
                {
                    throw new System.ArgumentException(
                        "the value of the Mark field should be between 1 (unsatisfactory) and 5 (excellent)");
                }

                _mark = value;
            }
        }
    }
}