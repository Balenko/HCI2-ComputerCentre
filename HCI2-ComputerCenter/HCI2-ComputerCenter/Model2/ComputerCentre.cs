using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI2_ComputerCenter.Model
{
    class ComputerCentre
    {
        private List<Classroom> _classrooms;

        private List<Course> _courses;
        
        private List<Software> _software;

        private List<Subject> _subjects;

        public List<Classroom> Classrooms
        {
            get { return _classrooms; }
            set
            {
                _classrooms = value;
            }
        }

        public List<Course> Courses
        {
            get { return _courses; }
            set
            {
                _courses = value;
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

        public List<Software> Software
        {
            get { return _software; }
            set
            {
                _software = value;
            }
        }
    }
}
