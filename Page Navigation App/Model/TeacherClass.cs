using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page_Navigation_App.Model
{
    public class TeacherClass
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Rate { get; set; }
        public int Age { get; set; }
        public int Mobile { get; set; }
        public string Img { get; set; }

        public override string ToString()
        {
            return $"Id={Id}{Environment.NewLine}" +
                   $"Name={Name}{Environment.NewLine}" +
                   $"Rate={Rate}{Environment.NewLine}" +
                   $"Age={Age}{Environment.NewLine}" +
                   $"Mobile={Mobile}{Environment.NewLine}" +
                   $"Img={Img}";
        }
    }
}
