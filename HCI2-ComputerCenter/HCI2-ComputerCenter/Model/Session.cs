using System;

namespace HCI2_ComputerCenter.Model
{
    public class Session
    {
        private Subject _subject;
        private DayOfWeek _day;
        private DateTime _time;
        private int _terms;

        public Subject Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
            }
        }

        public DayOfWeek Day
        {
            get { return _day; }
            set
            {
                _day = value;
            }
        }

        public DateTime Time
        {
            get { return _time; }
            set
            {
                _time = value;
            }
        }

        public int Terms
        {
            get { return _terms; }
            set
            {
                _terms = value;
            }
        }
    }
}