using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class InferenceEngine
    {
        List<String> workingMem;
        public InferenceEngine()
        {

        }

        public string forwardChaining(List<String> workingMem, List<Rule> rules)
        {
            string output = "";
            foreach(Rule workingRule in rules)
            {
                if(workingRule.requirementsMet("F", workingMem))
                {
                    output += workingRule.Course + Environment.NewLine;
                }
            }

            return output;
        }

        public void backwardChaining(List<String> workingMem, List<Rule> rules, String course)
        {

        }
    }
}
