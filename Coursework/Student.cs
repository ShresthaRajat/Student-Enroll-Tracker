using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Coursework
{
    class Student
    {
        private string _filePath = "student.json";
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public DateTime RDate { get; set; }
        public string Course { get; set; }
        public string Status { get; set; }


        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);
        }

        public void Edit (Student info)
        {
            List<Student> list = List();
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            list.Remove(s);
            list.Add(info);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, data, false);
        }

        public void Delete (Student info)
        {
            List<Student> list = List();
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            list.Remove(s);
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, data, false);
        }

        public List<Student> List()
        {
            
            string student = Utility.ReadFromTextFile(_filePath);

            if (student != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(student);
                return lst;
            }
            return null;
        }
    }
}
