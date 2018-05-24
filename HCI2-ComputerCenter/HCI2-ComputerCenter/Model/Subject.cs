using System.Collections.Generic;

namespace HCI2_ComputerCenter.Model
{
    public class Subject 
    {
        public static int TermLenght = 45;

        private string _id;
        private string _name;
        private Course _course;
        private string _description;
        private int _groupSize;
        private int _minimumTermsPerSession = 1;
        private int _requiredTerms = 1;
        private bool _requiresProjector;
        private bool _requiresBlackboard;
        private bool _requiresSmartboard;
        private Enums.Platform _requiredPlatform;
        private List<Software> _requiredSoftware;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public Course Course
        {
            get { return _course; }
            set
            {
                _course = value;
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

        public int GroupSize
        {
            get { return _groupSize; }
            set
            {
                _groupSize = value;
            }
        }

        public int MinimumTermsPerSession
        {
            get { return _minimumTermsPerSession; }
            set
            {
                _minimumTermsPerSession = value;
            }
        }

        public int RequiredTerms
        {
            get { return _requiredTerms; }
            set
            {
                _requiredTerms = value;
            }
        }

        public bool RequiresProjector
        {
            get { return _requiresProjector; }
            set
            {
                _requiresProjector = value;
            }
        }

        public bool RequiresBlackboard
        {
            get { return _requiresBlackboard; }
            set
            {
                _requiresBlackboard = value;
            }
        }

        public bool RequiresSmartboard
        {
            get { return _requiresSmartboard; }
            set
            {
                _requiresSmartboard = value;
            }
        }

        public Enums.Platform RequiredPlatform
        {
            get { return _requiredPlatform; }
            set
            {
                _requiredPlatform = value;
            }
        }

        public List<Software> RequiredSoftware
        {
            get { return _requiredSoftware; }
            set
            {
                _requiredSoftware = value;
            }
        }
    }
}