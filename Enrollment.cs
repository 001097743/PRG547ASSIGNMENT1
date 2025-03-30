using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PRG547ASSIGNMENT1
{
    class Enrollment
    {
        const string DEF_DATE_ENROLLED = "Not provided";
        const string DEF_GRADE = "Not provided";
        const string DEF_SEMESTER = "Not provided";
        public string DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }

        public Enrollment(string dateEnrolled, string grade, string semester, Subject subject)
        {

            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        public Enrollment() : this(DEF_DATE_ENROLLED, DEF_GRADE, DEF_SEMESTER, new Subject()) { }

        public override string ToString()
        {
            return $"\n" +
                $"[Enrollment]\n" +
                $"Date Enrolled: {DateEnrolled}\n" +
                $"Grade: {Grade}\n" +
                $"Semester: {Semester}\n" +
                $"{Subject}\n" +
                $"";
        }
    }
}
