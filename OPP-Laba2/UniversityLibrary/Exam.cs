using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Exam
    {       
        private string subject;
        public string Subject { get { return subject; } set { subject = value; } }

        private string mark;
        public string Mark { get { return mark; } set { mark = value; } }
        
        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }

        public override string ToString() => "\tSubject: " + Subject + "\n\tMark: " + Mark + "\n\tDate: " + getDateInFormat() + "\n";
        private string getDateInFormat() => Date.ToString().Split()[0];
    }
}
