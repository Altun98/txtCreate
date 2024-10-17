using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtCreate
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public int Age{get;set;}
    public string Address { get; set; }
    public Student()
    {
        ID = AvtomaticID.get_id();
    }
    public Student(string _name, string _surName, string _patronymic, int _age, string _address)
    {
        this.Name = _name;
        this.SurName = _surName;
        this.Patronymic = _patronymic;
        this.Age = _age;
        this.Address = _address;
    }
    public string GetStudentRowString()
    {
        return $"{ID},{Name},{SurName},{Patronymic},{Age},{Address}";
    }
    public void Print()
    {
        Console.WriteLine(GetStudentRowString());
    }
}
}
