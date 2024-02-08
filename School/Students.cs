using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Students
    {

        private string name;
        private int count;

        public Students(string name, int count)
        {
            this.name = name;
            this.count = count;
        }

        public string Name 
        {
            get { return name; } 
            set { name = value; }
        }
        public int Count 
        {
            get { return count; }
            set { count = value; }
        }

        //public int Combine()
        //{
        //    int combine = count.
        //}
    }
}
