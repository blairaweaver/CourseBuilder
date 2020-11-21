using System;
using System.Collections.Generic;
using System.Text;

namespace CourseBuilder
{
    class Controller
    {
        RuleReader reader;
        public Controller()
        {
            reader = new RuleReader();
            reader.createRules();
        }
    }
}
