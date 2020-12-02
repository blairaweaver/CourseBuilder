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
        public Rule backwardChaining(List<string> workingMem, List<Rule> rules, string course)
        {
            //make a new list so that we can add the four from the forward chaining without modifying the 
            //workingMemory
            List<string> workingSet = new List<string>(workingMem);

            //get the courses from forward chaining and add the 1st 4 to the workingSet
            List<Rule> ruleList = forwardChaining(workingMem, rules);
            for(int i = 0; i < 4; i++)
            {
                workingSet.Add(ruleList[i].Course);
            }

            foreach(Rule workingRule in rules)
            {
                if(workingRule.Course == course && workingRule.requirementsMet("S", workingSet))
                {
                    return workingRule;
                }
            }

            return null;
        }
    }
}
