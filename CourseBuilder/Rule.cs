using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class Rule
    {
        private List<String> req;
        private String sem;
        private String course;
        public String Course
        {
            get { return course; }
        }

        public Rule(List<String> requirements, String semester, String course) 
        {
            req = requirements;
            sem = semester;
            this.course = course;
        }


    }
}
