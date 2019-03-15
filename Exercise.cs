using System;
using System.Collections.Generic;
namespace tracking_student
{
   public class Exercise
    {
        public Exercise(int exerciseId, string exerciseName, string exerciseLanguage){
            ExerciseId = exerciseId;
            ExerciseName = exerciseName;
            ExerciseLanguage = exerciseLanguage;
        }

        public string ExerciseName {get; set;}

        public string ExerciseLanguage {get; set;}

        public int ExerciseId {get; set;}



    }
    public class ExerciseReport
    {
        public string ExerciseName1 { get; set; }
        public int ExerciseLanguage1 { get; set; }
    }
}
