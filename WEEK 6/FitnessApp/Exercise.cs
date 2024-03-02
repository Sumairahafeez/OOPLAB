using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class Exercise
    {
        private string Type;
        private string Steps;
        private int NoOfTimes;
        public Exercise() { }
        public Exercise(string type, string steps, int no)
        {
            SetType(type);
            SetSteps(steps);
            SetNoOfItems(no);
        }
        public void SetType(string type)
        {
            Type = type;
        }
        public string GetType()
        {
            return Type;
        }
        public void SetSteps(string steps)
        {
            Steps = steps.Trim();
        }
        public string GetSteps()
        {
            return Steps;
        }
        public int GetNoOfItems()
        {
            return NoOfTimes;
        }
        public void SetNoOfItems(int noOfTimes)
        {
            this.NoOfTimes = noOfTimes;
        }
    }
}
