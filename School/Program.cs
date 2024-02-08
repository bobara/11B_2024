namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<School> schoolList = new List<School>();
            List<Students> studentList = new List<Students>();

            try
            {
                while (true)
                {
                    string[] inputSchool = Console.ReadLine().Split("; ").ToArray();
                    if (inputSchool[0].ToLower() == "finish")
                    {
                        break;
                    }

                    string schoolName = inputSchool[0];
                    string city = inputSchool[1];
                    School currentSchool = new School(schoolName, city);


                    string[] inputStudents = Console.ReadLine().Split("; ").ToArray();

                    foreach(var student in inputStudents) 
                    {
                        string[] currentStudentData = student.Split("-").ToArray();
                        string name = currentStudentData[0];
                        int count = int.Parse(currentStudentData[1]);
                        Students currentStudents = new Students(name, count);
                        currentSchool.Students.Add(currentStudents);
                        schoolList.Add(currentSchool);
                    }

                    //for (int i = 0; i < inputStudents.Length; i= i+1)
                    //{

                    //    Students currentStudents = new Students(inputStudents[i], int.Parse(inputStudents[i + 1]));
                    //    currentSchool.Students.Add(currentStudents);
                    //}
                    //schoolList.Add(currentSchool);

                }

                var sordetSchools = schoolList.OrderBy(x=>x.Name).ThenBy(x=>x.City).ThenBy(x=>x.Students.Count).ToList();

                foreach(var school in schoolList)
                {
                    Console.WriteLine(school.ToString());
                }
            }

            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}