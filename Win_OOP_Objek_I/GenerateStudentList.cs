using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Win_OOP_Objek_I
{

    public static class GenerateStudentList
    {
        private static Random ran = new Random();

        private static List<string> names = new List<string>()
        {
        "Karel",
        "Marcel",
        "Lenka",
        "Lucka",
        "Lumir"
        };

        private static List<string> surname = new List<string>()
          {
          "Novak",
          "Sovak",
          "SLovak",
          "Urbancik",
          "Urbis"
          };

        public static List<Student> GetStudents(int count)
        {
            List<Student> res = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                res.Add(new Student()
                {
                    jmeno = names.GetRandom(),
                    prijmeni = surname.GetRandom(),
                    vek = ran.Next(99)
                });

            }
            return res;
        }

        private static T GetRandom<T>(this List<T> list)
        {
            return list[ran.Next(list.Count - 1)];
        }

    }
   
    


}
