using System;
using System.Collections.Generic;

namespace tracking_student
{
    public class Student
    {
        public Student(int cohortId, string firstName, string lastName, string slackHandle, string cohortName, int studentId){
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortId = cohortId;
            studentExercises = new List<Exercise>();
            StudentId = studentId;
       }

       public int StudentId {get; set;}

       public string FirstName {get; set;}

       public string LastName {get; set;}

       public int CohortId {get; set;}

       public List<Exercise> studentExercises {get; set;}
    }
}