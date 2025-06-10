﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP5
{
    public class Teacher
    {
        private Collection students;

        public Teacher()
        {
            students = new ListOfStudent();
        }

        public void setStudents(Collection _students)
        {
            students = _students;
        }

        public void goToClass(Student student)
        {
            students.addStudent(student);
        }

        public void teachingAClass()
        {
            Student student;
            IteratorOfStudent iterator = students.getIterator();

            // Pasar lista
            Console.WriteLine("Good morning\n\n");
            Console.WriteLine("I'm going to take attendance");
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                Console.WriteLine("\t" + student.getName() + " is present");
                iterator.next();
            }
            Console.WriteLine("\n\n");

            // tomar examen
            Console.WriteLine("I'm going to take an exam");
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                takeAnExam(student);
                iterator.next();
            }
            Console.WriteLine("\n\n");

            // mostrar resultado
            Console.WriteLine("Exam results");
            students.sort();
            iterator.beginning();
            while (!iterator.end())
            {
                student = iterator.current();
                Console.WriteLine(student.showResult() + "\n");
                iterator.next();
            }
        }

        private void takeAnExam(Student student)
        {
            int hit = 0;
            for (int i = 0; i < 10; i++)
            {
                int answer = student.yourAnswerIs(i);
                if (answer == (i % 3))
                    hit++;
            }
            student.setScore(hit);

            Console.WriteLine("\t" + student.getName() + "'s score is " + hit.ToString());
        }
    }
}
