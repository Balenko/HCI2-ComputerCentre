using System.Collections.Generic;
using System.Linq;

namespace HCI2_ComputerCenter.Model
{
    public class Classroom
    {
        private string _id;
        private string _description;
        private int _seats;
        private bool _hasProjector;
        private bool _hasBlackboard;
        private bool _hasSmartboard;
        private Enums.Platform _platform;
        private List<Software> _installedSoftware;
        private Schedule _schedule;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        public int Seats
        {
            get { return _seats; }
            set
            {
                _seats = value;
            }
        }

        public bool HasProjector
        {
            get { return _hasProjector; }
            set
            {
                _hasProjector = value;
            }
        }

        public bool HasBlackboard
        {
            get { return _hasBlackboard; }
            set
            {
                _hasBlackboard = value;
            }
        }

        public bool HasSmartboard
        {
            get { return _hasSmartboard; }
            set
            {
                _hasSmartboard = value;
            }
        }

        public Enums.Platform Platform
        {
            get { return _platform; }
            set
            {
                _platform = value;
            }
        }

        public List<Software> InstalledSoftware
        {
            get { return _installedSoftware; }
            set
            {
                _installedSoftware = value;
            }
        }

        public Schedule Schedule
        {
            get { return _schedule; }
            set
            {
                _schedule = value;
            }
        }
    }
}