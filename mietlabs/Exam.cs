﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mietlabs
{
    internal class Exam
    {
        public Exam(string name_sub, int mark, System.DateTime date)
        {
            this.name_sub = name_sub;
            this.mark = mark;
            this.date = date;
        }

        public Exam()
        {
            name_sub = "";
            mark = 0;
            date = new DateTime(1978, 1, 1);
        }
        public string name_sub;
        public int mark;
        public System.DateTime date;

        public override string ToString()
        {
            return Convert.ToString(name_sub) + " " + Convert.ToString(mark) + " " + Convert.ToString(date);
        }

    }
}