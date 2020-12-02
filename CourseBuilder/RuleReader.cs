using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace CourseBuilder
{
    class RuleReader
    {
        private List<Rule> rules;

        public RuleReader() 
        {
            rules = new List<Rule>();
        }

        public List<Rule> createRules()
        {
            List<string> req;
            string course = "";
            string sem = "";
            int count;
            //load file
            XmlDocument doc = new XmlDocument();
            string fileName = Path.Combine(Directory.GetCurrentDirectory(), "Rules.xml");
            doc.Load(fileName);

            //keep track of the number of rules
            int numRules = 0;

            //cycle through the nodes
            foreach(XmlNode xmlNode in doc.DocumentElement)
            {
                req = new List<string>();
                count = 0;
                
                foreach(XmlNode child in xmlNode)
                {
                    if (count == 0)
                    {
                        course = child.InnerText;
                    }
                    else if (count == 1)
                    {
                        sem = child.InnerText;
                    }
                    else
                    {
                        req.Add(child.InnerText);
                    }
                    count++;
                }
                rules.Add(new Rule(numRules, req, sem, course));

                numRules++;
            }

            //return the list
            return rules;
        }
    }
}
