using System.Collections.Generic;

namespace HCI2_ComputerCenter.Model
{
    public class Schedule
    {
        private string _id;
        private List<Session> _sessions;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public List<Session> Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value;
            }
        }
    }
}