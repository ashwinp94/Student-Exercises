using System;

namespace tracking_student
{
    public class Cohort
    {
        public Cohort(int cohortId, string cohortName){
            CohortId = cohortId;
            CohortName = cohortName;
            CohortPeople = new List<Cohort>();
        }

        public string CohortName {get; set;}

        public int CohortId {get; set;}

        public List<Cohort> CohortPeople {get; set;}

    }
}
