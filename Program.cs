using System;
using System.Collections.Generic;

namespace tracking_student
{
    class Program
    {
        static void Main()
        {
//Creating Everything

            Exercise Exercise1 = new Exercise(exerciseId: 1, exerciseName:"Lists", exerciseLanguage:"C#");
            Exercise Exercise2 = new Exercise(exerciseId: 2, exerciseName:"Dictionary", exerciseLanguage:"C#");
            Exercise Exercise3 = new Exercise(exerciseId: 3, exerciseName:"Ternary Traveler", exerciseLanguage:"Javascript");
            Exercise Exercise4 = new Exercise(exerciseId: 4, exerciseName:"Deleting Data", exerciseLanguage:"Javascript");
            Exercise Exercise5 = new Exercise(exerciseId: 5, exerciseName:"REACT: Conditional Routing", exerciseLanguage:"REACT");
            Exercise Exercise6 = new Exercise(exerciseId: 6, exerciseName:"REACT: URL Routing", exerciseLanguage:"REACT");

            Cohort Cohort1 = new Cohort(cohortId: 1, cohortName:"Cohort 29");
            Cohort Cohort2 = new Cohort(cohortId: 2, cohortName:"Cohort 30");
            Cohort Cohort3 = new Cohort(cohortId: 3, cohortName:"Cohort 31");


            Student Student1 = new Student(cohortId:1, firstName:"Ashwin", lastName:"Prakash", slackHandle:"ashwinp94", studentId:1, co: Cohort1);
            Student Student4 = new Student(cohortId:1, firstName:"Mary", lastName:"Remo", slackHandle:"MaryRemo", studentId:4, co: Cohort1);
            Student Student2 = new Student(cohortId:2, firstName:"Brian", lastName:"Neal", slackHandle:"BrianNeal", studentId:2, co: Cohort2);
            Student Student3 = new Student(cohortId:2, firstName:"Ryan", lastName:"Dillinger", slackHandle:"RyanDillinger", studentId:3, co: Cohort2);
            Student Student5 = new Student(cohortId:3, firstName:"Michael", lastName:"Yankura", slackHandle:"MichaelYankura", studentId:5, co: Cohort3);
            Student Student6 = new Student(cohortId:3, firstName:"Chris", lastName:"Morgan", slackHandle:"ChrisMorgan", studentId:6, co: Cohort3);

            Instructor Instructor1 = new Instructor(instructorId:1, firstName:"Jisie", lastName:"Davids", slackHandle:"JisieDavid", cohortId:3, co: Cohort3);
            Instructor Instructor2 = new Instructor(instructorId:2, firstName:"Andy", lastName:"Collins", slackHandle:"AndyCollins", cohortId:1, co: Cohort1);
            Instructor Instructor3 = new Instructor(instructorId:3, firstName:"Steve", lastName:"Brownlee", slackHandle:"steve", cohortId:2, co: Cohort2);

//Student List
        List<Student> allStudents = new List<Student>();
            allStudents.Add(Student1);
            allStudents.Add(Student2);
            allStudents.Add(Student3);
            allStudents.Add(Student4);
            allStudents.Add(Student5);
            allStudents.Add(Student6);

            Console.WriteLine("All students at NSS:");
            foreach(Student student in allStudents){
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
               }

//Exercise List
        List<Exercise> allExercises = new List<Exercise>();
            allExercises.Add(Exercise1);
            allExercises.Add(Exercise2);
            allExercises.Add(Exercise3);
            allExercises.Add(Exercise4);
            allExercises.Add(Exercise5);
            allExercises.Add(Exercise6);

            Console.WriteLine("All exercises at NSS:");
            foreach(Exercise exercise in allExercises){
                    Console.WriteLine($"Name: {exercise.ExerciseName} Language: {exercise.ExerciseLanguage}");
               }

//Assigning to Cohorts

            Cohort1.studentList.Add(Student1);
            Cohort1.studentList.Add(Student4);
            Cohort2.studentList.Add(Student2);
            Cohort2.studentList.Add(Student3);
            Cohort3.studentList.Add(Student5);
            Cohort3.studentList.Add(Student6);

            Cohort1.intructorList.Add(Instructor2);
            Cohort2.intructorList.Add(Instructor3);
            Cohort3.intructorList.Add(Instructor1);

            Console.WriteLine("Students assigned to cohorts: ");
            Cohort1.ListCohort();
            Cohort2.ListCohort();
            Cohort3.ListCohort();

//Assigning Exercises

            Instructor1.AssignExercises(Student5, Exercise3);
            Instructor1.AssignExercises(Student5, Exercise4);
            Instructor1.AssignExercises(Student6, Exercise3);
            Instructor1.AssignExercises(Student6, Exercise4);

            Instructor2.AssignExercises(Student1, Exercise1);
            Instructor2.AssignExercises(Student1, Exercise2);
            Instructor2.AssignExercises(Student4, Exercise1);
            Instructor2.AssignExercises(Student4, Exercise2);

            Instructor3.AssignExercises(Student2, Exercise5);
            Instructor3.AssignExercises(Student2, Exercise6);
            Instructor3.AssignExercises(Student3, Exercise5);
            Instructor3.AssignExercises(Student3, Exercise6);

            Console.WriteLine("What students are working on: ");

            // Student1.ListExercises();
            // Student2.ListExercises();
            // Student3.ListExercises();
            // Student4.ListExercises();
            // Student5.ListExercises();
            // Student6.ListExercises();


        }
    }
}
