﻿using System;
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
        List<string> workingMemory;
        Form1 mainForm; //this is so this class can modify the text boxes on the form
        InferenceEngine inferenceEngine;
        WorkingMemory displayMemory;
        bool displayMemBool;
        public Controller(Form1 form)
        {
            reader = new RuleReader();
            rules = reader.createRules();
            mainForm = form;
            inferenceEngine = new InferenceEngine();
            displayMemory = new WorkingMemory();

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
            displayMemory = new WorkingMemory();
        }

        //this will add the course to the working memory
        //this will also move any rules that have this as an output to 
        private void addToWorkingMem(List<string> Courses)
        {
            //add the courses to working memory
            workingMemory = new List<string>(Courses);

            if (displayMemBool)
            {
                displayMemory.addToOutput(workingMemory);
            }

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

        //This function will determine the next two semesters of classes
        private void getJuniorSchedule()
        {
            //get the fall courses
            getCourses("F");

            string output = moveToMemory();

            //send the output to the fall textbox and clear
            mainForm.addJuniorCourses(output, "F");

            //get the Spring Courses
            getCourses("S");

            output = moveToMemory();

            //send the output to the fall textbox and clear
            mainForm.addJuniorCourses(output, "S");
            output = "";
        }

        //this is to reduce the number of lines of code in getJunior since
        //this is used after getting the courses from fall and spring
        //loop through the rules to find courses
        //This will be done twice: fall and spring
        private string moveToMemory()
        {
            string output = "";
            //add the courses to the working mem and to the Gui
            //add the rules to Non applicable
            for (int i = 0; i < firedRules.Count; i++)
            {
                string courseName = firedRules[i].Course;
                workingMemory.Add(courseName);
                output += courseName + Environment.NewLine;
                nonApplicable.Add(firedRules[i]);
                firedRules.RemoveAt(i);
                i--;

                if (displayMemBool)
                {
                    displayMemory.addToOutput(workingMemory);
                }
            }

            return output;
        }

        //This function will get four course for the semester given
        //courses stored in the FiredRules
        private void getCourses(string semester)
        {
            List<string> workingList = new List<string>();
            //Search for the courses
            for (int i = 0; i < workingRules.Count; i++)
            {
                //if the requirements are met, move to firedRules List
                //and remove from working rules
                if (workingRules[i].requirementsMet(semester, workingMemory))
                {
                    //if we haven't encountered a rule that has an outcome of the course
                    //add rule to fired list and remove
                    if(!workingList.Contains(workingRules[i].Course))
                    {
                        workingList.Add(workingRules[i].Course);
                        firedRules.Add(workingRules[i]);
                        workingRules.RemoveAt(i);
                        i--;
                    }
                    //else, move the rule to the non applicable and remove
                    else
                    {
                        nonApplicable.Add(workingRules[i]);
                        workingRules.RemoveAt(i);
                        i--;
                    }
                }

                //check to see if we have four course and break loop if we do
                if (firedRules.Count == 4)
                {
                    break;
                }
            }
        }

        //method called by the GUI to run
        //This will call the other functions needed

        //Nothing prevents this from being called again before end session is clicked
        public void run()
        {
            List<Rule> ruleList = inferenceEngine.forwardChaining(workingMemory, workingRules);
            ForwardOutput forwardOutput = new ForwardOutput(ruleList);
            forwardOutput.Show();
        }

        public void run(string Course)
        {
            
            Rule? triggerRule = inferenceEngine.backwardChaining(workingMemory, workingRules, Course);

            BackwardOutput backwardOutput = new BackwardOutput();
            backwardOutput.updateEligible(triggerRule, Course);
            backwardOutput.Show();
        }

        public void fillSchedule(List<string> Courses, bool displayMem)
        {
            this.displayMemBool = displayMem;
            if(displayMemBool)
            {
                displayMemory.Show();
            }
            addToWorkingMem(Courses);
            getJuniorSchedule();
        }
    }
}
