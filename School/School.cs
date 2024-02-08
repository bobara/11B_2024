using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        private string name;
        private string city;
        private List<Students> students;

        public School(string name, string city)
        {
            this.name = name;
            this.city = city;
            this.students = new List<Students>();
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (String.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("Invalid name!");
                }
                name = value; 
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if(city.Length <= 3)
                {
                    throw new ArgumentException("Invalid city!");
                }
                city = value;
            }
        }

        public List<Students> Students 
        { 
            get { return students; } 
        }

        public override string ToString()
        {
            string result = $"{Name} from {City} - count of students {this.Students.Sum(x=>x.Count)}";
            return result;

        }




    }
}
