﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodologiasTP4
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            if (s1.equals(s2))
                return 0;
            else
            if (s1.lessThan(s2))
                return 1;
            else
                return -1;
        }
    }
}
