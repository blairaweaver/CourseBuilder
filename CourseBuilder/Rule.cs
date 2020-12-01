using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class Rule
    {
        private List<string> req;
        private string sem;
        private string course;
        public string Course
        {
            get { return course; }
        }
        public string Semester
        {
            get { return sem; }
        }

        public Rule(List<string> requirements, string semester, string course) 
        {
            req = requirements;
            sem = semester;
            this.course = course;
        }

        //take the Semester and working memory to see if this rule can fire
        public Boolean requirementsMet(string semester, List<string> workingMem)
        {
            //semester is a faster check, so do that first
            //if semester is correct, then check the other requirements
            //if our semester is O, then it doesn't matter which semester it is
            if (sem == "O" || sem == semester )
            {
                //cycle throught the prereqs
                foreach (string prereq in req)
                {
                    //if a prereq isn't in the working memory, return false
                    if (!workingMem.Contains(prereq))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            //return if the rule is triggered
            return true;
        }
    }
}
