using System.Collections.Generic;

namespace HCI2_ComputerCenter.Model
{
    public class Software
    {
        private string _id;
        private string _name;
        private Enums.Platform _platform;
        private string _developer;
        private string _softwareWebsite;
        private string _yearReleased;
        private double _price;
        private string _description;
        private List<Classroom> _classrooms;
        private List<Subject> _subjects;

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

        public Enums.Platform Platform
        {
            get { return _platform; }
            set
            {
                _platform = value;
            }
        }

        public string Developer
        {
            get { return _developer; }
            set
            {
                _developer = value;
            }
        }

        public string SoftwareWebsite
        {
            get { return _softwareWebsite; }
            set
            {
                _softwareWebsite = value;
            }
        }

        public string YearReleased
        {
            get { return _yearReleased; }
            set
            {
                _yearReleased = value;
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
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

        public List<Classroom> Classrooms
        {
            get { return _classrooms; }
            set
            {
                _classrooms = value;
            }
        }

        public List<Subject> Subjects
        {
            get { return _subjects; }
            set
            {
                _subjects = value;
            }
        }
    }
}