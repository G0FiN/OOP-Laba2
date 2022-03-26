using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Degree
    {        
        public bool bachelor;
        public bool specialist;
        public bool master;

        public override string ToString() {
            string result;
            result = this.bachelor ? "\tBachelor - OK\n\t" : "\tBachelor - X\n\t";
            result += this.specialist ? "Specialist - OK\n\t" : "Specialist - X\n\t";
            result += this.master ? "Master - OK\n\t" : "Master - X\n";
            return result;
        }        
    }
}
