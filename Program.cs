using System;
using System.Collections.Generic;
using System.Linq;

namespace AssigningStudentExercisesWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var cohort35 = new Cohort()
            {
                CohortName = "C35"
            };
            var cohort37 = new Cohort()
            {
                CohortName = "C37"
            };
            var students = new List<Student>();
            students.Add(new Student
            {
                StudentCohort = cohort37,
                    FirstName = "Luis",
                    LastName = "Chavez",
                    CurrentExercises = new List<Exercises>()
                    {
                        new Exercises()
                        {
                            NameOfExercise = "Kennel",
                                LanguageOfExercise = "JS"
                        }
                    }

            });
            students.Add(new Student
            {
                StudentCohort = cohort37,
                    FirstName = "Onterio",
                    LastName = "Wright",
                    CurrentExercises = new List<Exercises>()
                    {
                        new Exercises()
                            {
                                NameOfExercise = "Kennel",
                                    LanguageOfExercise = "JS"
                            },
                            new Exercises()
                            {
                                NameOfExercise = "LINQ",
                                    LanguageOfExercise = "C#"
                            }
                    }
            });
            students.Add(new Student
            {
                StudentCohort = cohort35,
                    FirstName = "Tyler",
                    LastName = "Davis"
            });
            students.Add(new Student
            {
                StudentCohort = cohort37,
                    FirstName = "Akemo",
                    LastName = "Wright",
                    CurrentExercises = new List<Exercises>()
                    {
                        new Exercises()
                        {
                            NameOfExercise = "NBA",
                                LanguageOfExercise = "JS"
                        }
                    }
            });

            var exercises = new List<Exercises>
            {
                new Exercises
                {
                LanguageOfExercise = "C#",
                NameOfExercise = "LINQ"
                },
                new Exercises
                {
                LanguageOfExercise = "JS",
                NameOfExercise = "Kennel"
                },
                new Exercises
                {
                LanguageOfExercise = "JS",
                NameOfExercise = "Nutshell"
                },
                new Exercises
                {
                LanguageOfExercise = "JS",
                NameOfExercise = "NBA"
                },
            };

            var allJsExercise = exercises.Where(exercise =>
            {
                return exercise.LanguageOfExercise == "JS";
            });

            foreach (var exercise in allJsExercise)
            {
                Console.WriteLine($"Javascript Exercises: {exercise.NameOfExercise}");
            }

            var studentsOrderedByLastName = students.OrderByDescending(student =>
            {
                return student.LastName;
            });

            Console.WriteLine("Students: ");

            foreach (var student in studentsOrderedByLastName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentsWithNoExercises = students.Where(student =>
            {
                int exercisesCount = student.CurrentExercises.Count;
                return exercisesCount == 0;
            });

            Console.WriteLine("These students are not working on any exercises");

            foreach (var student in studentsWithNoExercises)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentWithMostExercises = students.OrderByDescending(student =>
            {
                return student.CurrentExercises.Count;
            }).FirstOrDefault();

            Console.WriteLine("Student with the most exercises: ");
            Console.WriteLine($"{studentWithMostExercises.FirstName} {studentWithMostExercises.LastName}");

            var groups = students.GroupBy(student => student.StudentCohort.CohortName);

            foreach (var group in groups)
            {
                if (group.Count() == 1)
                {
                    Console.WriteLine($"There is {group.Count()} student in {group.Key}");
                }
                else
                {
                    Console.WriteLine($"There are {group.Count()} students in {group.Key}");

                }
            }
        }
    }
}