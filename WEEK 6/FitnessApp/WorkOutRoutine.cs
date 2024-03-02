using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class WorkOutRoutine
    {
        int NoOfDays;
       private List<Exercise> Exerciselist;  
        public WorkOutRoutine(int days)
        {
            NoOfDays = days;
            Exerciselist = new List<Exercise>();
        }
        public void SetExerciseList(string type,string step,int noOfTimes)
        {
            Exercise exercise = new Exercise(type,step,noOfTimes);
            Exerciselist.Add(exercise);
        }
        public int GetListCount()
        {
            return Exerciselist.Count;
        }
        public string GetExerciseSteps(int Index)
        {
            return Exerciselist[Index].GetSteps();
        }
    }
}
