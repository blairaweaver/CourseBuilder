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

        //take the Semester and working memory to see if this rule can fire
        public Boolean requirementsMet(String semester, List<String> workingMem)
        {
            //semester is a faster check, so do that first
            //if semester is correct, then check the other requirements
            if (sem == semester)
            {
                //cycle throught the prereqs
                foreach (String prereq in req)
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
