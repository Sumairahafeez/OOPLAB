using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   //IT IS A COMPOSITION FUNCTION IN WHICH EXERCISE IS COMPOSED IN WORKROUTINE
            WorkOutRoutine W = new WorkOutRoutine(7);
            W.SetExerciseList("Thighs", "Cycle AROUND", 7);
            W.SetExerciseList("Feets", "Walk", 2);
            Console.WriteLine("Your Work Routine Has Following Exercise: ");
            for(int i = 0; i<W.GetListCount() ; i++)
            {
                Console.WriteLine(W.GetExerciseSteps(i));
            }
            Console.ReadKey();
        }
    }
}
