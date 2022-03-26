using System;

namespace UniversityLibrary
{
    public class Student: IComparable<Student>
    {        
        public Person person { get; set; }
        
        public Degree degree { get; set; }        
        
        public Exam[] exams { get; set; }

        public override string ToString() 
            => new string('_', 50) + "\nStudent\n" + this.person + "Degree\n" + this.degree + "Passed exams\n" + getExamsList();
        
        private string getExamsList() 
        {
            string result = "";
            foreach (Exam item in this.exams)
                result += item.ToString() + "\n";
            return result;
        }

        public int CompareTo(Student other) => person.CompareTo(other.person);        
    }
}
