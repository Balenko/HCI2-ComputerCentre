using System;
using System.Collections.Generic;

namespace HCI2_ComputerCenter.Model
{
    public class Course
    {
        private string _id;
        private string _name;
        private DateTime _dateOpened;
        private string _description;
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

        public DateTime DateOpened
        {
            get { return _dateOpened; }
            set
            {
                _dateOpened = value;
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