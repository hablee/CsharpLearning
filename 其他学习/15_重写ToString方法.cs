using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Student
    {
        public int No { get; set; }
        public string name { get; set; }
        public string course { get; set; }
        public override string ToString()
        {
            return "--学员信息:--\n姓名: " + this.name + "\n学号: " +
                this.No.ToString() + "\n课程: " + this.course;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student()
            {
                name = "hablee",
                No=17721528,
                course="c#入门到放弃"
            };
            Student stu2 = new Student()
            {
                name="Yuki",
                No=17781345,
                course="matlab从入门到精通"
            };

            //分别输出2个实例的信息
            //WriteLine方法会自动调用ToString()方法
            Console.WriteLine(stu1);
            Console.WriteLine(stu2);

            Console.Read();
        }
    }
}
