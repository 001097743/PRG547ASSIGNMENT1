using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG547ASSIGNMENT1
{
    internal class Subject
    {
        const string DEF_SUBJECTCODE = "Not provided";
        const string DEF_SUBJECTNAME = "Not provided";
        const double DEF_COST = 0;
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        public Subject(string subjectCode, string subjectName, double cost)
        {
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            Cost = cost;
        }

        public Subject() : this(DEF_SUBJECTCODE, DEF_SUBJECTNAME, DEF_COST) { }
        public override string ToString()
        {
            return $"\n" +
                $"[Subject]\n" +
                $"Subject Code: {SubjectCode}\n" +
                $"Subject Name: {SubjectName}\n" +
                $"Cost: {Cost}\n" +
                $"";
        }
    }
}
