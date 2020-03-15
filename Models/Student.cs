using System;
using System.Collections.Generic;

namespace AssigningStudentExercisesWithLINQ
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public Cohort StudentCohort { get; set; }
    public List<Exercises> CurrentExercises { get; set; } = new List<Exercises>();
  }
}