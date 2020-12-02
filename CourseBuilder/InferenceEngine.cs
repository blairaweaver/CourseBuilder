using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class InferenceEngine
    {
        List<string> workingMem;
        public InferenceEngine()
        {

        }

        //This takes the working memeory and returns a list of rules that met the requirements
        public List<Rule> forwardChaining(List<string> workingMem, List<Rule> rules)
        {
            List<Rule> ruleList = new List<Rule>();
            foreach(Rule workingRule in rules)
            {
                if(workingRule.requirementsMet("F", workingMem))
                {
                    ruleList.Add(workingRule);
                }
            }

            return ruleList;
        }

        //this takes a course and determines if it can be taken in the spring.
        //
        //NEED TO RUN FORWARD CHAINING TO SEE WHAT IS TAKEN IN THE FALL!!!!!
        public Rule backwardChaining(List<string> workingMem, List<Rule> rules, string course)
        {
            foreach(Rule workingRule in rules)
            {
                if(workingRule.Course == course && workingRule.requirementsMet("S", workingMem))
                {
                    return workingRule;
                }
            }

            return null;
        }
    }
}
