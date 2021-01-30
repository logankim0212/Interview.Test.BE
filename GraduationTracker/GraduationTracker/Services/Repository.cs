﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker
{
    public class Repository
    {
        public Student GetStudent(int id)
        {
            Student[] students = GetStudents();

            foreach (Student student in students)
            {
                if (id == student.Id)
                {
                    return student;
                }
            }

            return null;
        }

        public Diploma GetDiploma(int id)
        {
            Diploma[] diplomas = GetDiplomas();

            foreach (Diploma diploma in diplomas)
            {
                if (id == diploma.Id)
                {
                    return diploma;
                }
            }

            return null;
        }

        public Requirement GetRequirement(int id)
        {
            Requirement[] requirements = GetRequirements();

            foreach (Requirement requirement in requirements)
            {
                if (id == requirement.Id)
                {
                    return requirement;
                }
            }

            return null;
        }

        private Diploma[] GetDiplomas()
        {
            return new[]
            {
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = new int[]{100,102,103,104}
                }
            };
        }

        private Requirement[] GetRequirements()
        {
            return new[]
            {
                new Requirement{
                    Id = 100,
                    Name = "Math",
                    MinimumMark=50,
                    Courses = new int[]{1},
                    Credits=1
                },
                new Requirement{
                    Id = 102,
                    Name = "Science",
                    MinimumMark=50,
                    Courses = new int[]{2},
                    Credits=1
                },
                new Requirement{
                    Id = 103,
                    Name = "Literature",
                    MinimumMark=50,
                    Courses = new int[]{3},
                    Credits=1
                },
                new Requirement{
                    Id = 104,
                    Name = "Physichal Education",
                    MinimumMark=50,
                    Courses = new int[]{4},
                    Credits=1
                }
            };
        }

        private Student[] GetStudents()
        {
            return new[]
            {
                new Student
                {
                    Id = 1,
                    Courses = new Course[]
                    {
                         new Course{Id = 1, Name = "Math", Mark=95 },
                         new Course{Id = 2, Name = "Science", Mark=95 },
                         new Course{Id = 3, Name = "Literature", Mark=95 },
                         new Course{Id = 4, Name = "Physichal Education", Mark=95 }
                    }
                },
                new Student
                {
                    Id = 2,
                    Courses = new Course[]
                    {
                         new Course{Id = 1, Name = "Math", Mark=80 },
                         new Course{Id = 2, Name = "Science", Mark=80 },
                         new Course{Id = 3, Name = "Literature", Mark=80 },
                         new Course{Id = 4, Name = "Physichal Education", Mark=80 }
                    }
                },
                new Student
                {
                    Id = 3,
                    Courses = new Course[]
                    {
                        new Course{Id = 1, Name = "Math", Mark=50 },
                        new Course{Id = 2, Name = "Science", Mark=50 },
                        new Course{Id = 3, Name = "Literature", Mark=50 },
                        new Course{Id = 4, Name = "Physichal Education", Mark=50 }
                    }
                },
                new Student
                {
                    Id = 4,
                    Courses = new Course[]
                    {
                        new Course{Id = 1, Name = "Math", Mark=40 },
                        new Course{Id = 2, Name = "Science", Mark=40 },
                        new Course{Id = 3, Name = "Literature", Mark=40 },
                        new Course{Id = 4, Name = "Physichal Education", Mark=40 }
                    }
                }
            };
        }
    }
}