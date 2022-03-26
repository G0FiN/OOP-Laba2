using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Person : IComparable<Person>
    {
        private string name;
        public string Name { get => this.name; set { this.name = value; } }
        
        private string surname;
        public string Surname { get => this.surname; set { this.surname = value; } }
        
        private DateTime birthday;
        public DateTime Birthday { get => this.birthday; set { this.birthday = value; } }

        public override string ToString() => "\tName: " + Name + "\n\tSurname: " + Surname + "\n\tBirthday: " + getBirthdayInFormat() + "\n";
        private string getBirthdayInFormat() => Birthday.ToString().Split()[0];
        public int CompareTo(Person other) => name.CompareTo(other.name);
    }
}
