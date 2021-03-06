using System;
using System.Collections.Generic;

namespace tracking_student
{
    public class Instructor
    {
        public Instructor(int instructorId, string firstName, string lastName, string slackHandle, int cohortId, Cohort co){
            InstructorId = instructorId;
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = co;
            CohortId = cohortId;
        }

        public int InstructorId {get; set;}

        public string FirstName {get; set;}

        public string LastName {get; set;}

        public string SlackHandle {get; set;}

        public Cohort Cohort {get; set;}

        public int CohortId {get; set;}

        public void AssignExercises(Student student, Exercise exercise){

            student.studentExercises.Add(exercise);

            Console.WriteLine($"{student.FirstName} {student.LastName} is assigned {exercise.ExerciseName} by {FirstName}");
        }

    }
}
