using System;
using System.Collections.Generic;

namespace AssigningStudentExercisesWithLINQ
{
  public class Cohort
  {
    public string CohortName { get; set; }
    public List<Student> ListOfStudents { get; set; } = new List<Student>();
    public List<Instructors> ListOfInstructors { get; set; } = new List<Instructors>();
  }
}