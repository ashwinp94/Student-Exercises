using System;
using System.Collections.Generic;

namespace tracking_student
{
    public class Student
    {
        public Student(int cohortId, string firstName, string lastName, string slackHandle, int studentId, Cohort co)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            CohortId = cohortId;
            Cohort = co;
            studentExercises = new List<Exercise>();
            StudentId = studentId;
        }

        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public int CohortId { get; set; }

        public Cohort Cohort { get; set; }


        public List<Exercise> studentExercises { get; set; }

        // public static bool IsEmpty<T>(this IEnumerable<T> list)
        // {
        //     if (studentExercises is ICollection<T>) return ((ICollection<T>)studentExercises).Count == 0;

        //     return !studentExercises.Any();
        // }
    }
}
