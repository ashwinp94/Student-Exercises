using System;
using System.Collections.Generic;

namespace tracking_student
{
    public class Cohort
    {
        public Cohort(int cohortId, string cohortName){
            CohortId = cohortId;
            CohortName = cohortName;
            studentList = new List <Student>();
            intructorList = new List <Instructor>();

        }

        public string CohortName {get; set;}

        public int CohortId {get; set;}

        public List<Student> studentList {get; set;}

        public List<Instructor> intructorList {get; set;}

        public void ListCohort(){

            foreach(Student student in studentList){
                Console.WriteLine($"{student.FirstName} {student.LastName} is in {CohortName}.");
                }

            foreach(Instructor instructor in intructorList){
                Console.WriteLine($"{instructor.FirstName} {instructor.LastName} is the teacher for {CohortName}.");
            }
        }
    }
}
