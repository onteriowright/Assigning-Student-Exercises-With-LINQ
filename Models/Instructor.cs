using System;
using System.Collections.Generic;

namespace AssigningStudentExercisesWithLINQ
{
  public class Instructors
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TeacherCohort { get; set; }
    public void AssignAssignment(Student student, Exercises assignment)
    {
      student.CurrentExercises.Add(assignment);
    }
  }
}