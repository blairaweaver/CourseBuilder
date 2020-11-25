using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class Controller
    {
        RuleReader reader;
        List<Rule> rules; //master list of rules
        List<Rule> workingRules; //the working list of rules that will be searched
        List<Rule> firedRules; //rules that have reqs meet will be moved to here temporarily
        List<Rule> nonApplicable; //this are rules for which a outcome course is in the transcript or in one of the semesters
        List<String> workingMemory;
        public Controller()
        {
            reader = new RuleReader();
            rules = reader.createRules();

            //initialize the other lists
            firedRules = new List<Rule>();
            nonApplicable = new List<Rule>();
            workingRules = new List<Rule>(rules); //shallow copy since the rules shouldn't be modified during operation
        }

        //This will clear all information from the current session
        public void endSession()
        {
            //reset the lists
            firedRules.Clear();
            nonApplicable.Clear();
            workingRules = new List<Rule>(rules);
        }

        //this will add the course to the working memory
        //this will also move any rules that have this as an output to 
        public void addToWorkingMem(List<String> Courses)
        {
            //add the courses to working memory
            workingMemory = new List<string>(Courses);

            //move any rule with the course as an outcome to the nonApplicable list
            for(int i = 0; i < workingRules.Count; i++)
            {
                if(workingMemory.Contains(workingRules[i].Course))
                {
                    nonApplicable.Add(workingRules[i]);
                    workingRules.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
