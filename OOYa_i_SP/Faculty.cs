using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYa_i_SP
{
    class Faculty
    {

        List<Person> allPersons = new List<Person>();
        System.IO.StreamWriter outputFile = new System.IO.StreamWriter("result.txt");

        public Faculty()
        {
            //allPersons = new List<Person>();
            //outputFile = new System.IO.StreamWriter("result.txt");
            string type, fio, grade, kurs, group, marks;
            System.IO.StreamReader everyoneFile =
                new System.IO.StreamReader("everyone.txt");

            while ((type = everyoneFile.ReadLine()) != null)
            {
                fio = everyoneFile.ReadLine();
                if (type == "П ")
                {
                    grade = everyoneFile.ReadLine();
                    allPersons.Add(new Lecturer(fio, grade));
                }

                else if (type == "С " || type == "C ")
                {
                    kurs = everyoneFile.ReadLine();
                    group = everyoneFile.ReadLine();
                    marks = everyoneFile.ReadLine();
                    allPersons.Add(new Student(fio, kurs, group, marks));
                }
                everyoneFile.ReadLine();
            }

            everyoneFile.Close();
        }

        public void writePersons()
        {
            foreach (Person p in allPersons)
            {
                p.Write(outputFile);
                outputFile.WriteLine("-------");
            }
        }

        public  void writeFivesOnly()
        {
            outputFile.WriteLine("\n  ОТЛИЧНИКИ:");
            foreach (Person p in allPersons)
            {
                if (p is Student && ((Student)p).isFivesOnly())
                {
                    p.Write(outputFile);
                    outputFile.WriteLine("-------");
                }
            }
            outputFile.Close();
        }

        public  void sortPersons()
        {
            allPersons = allPersons.OrderBy(w => w.fio).ToList();
        }

        ~Faculty()
        {
            //destructor
        }

    }
}
