using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYa_i_SP
{
    class Student:Person
    {
        private string _kurs, _group, _marks;
        public string kurs
        {
            set { _kurs = value; }
            get { return _kurs; }
        }
        public string group
        {
            set { _group = value; }
            get { return _group; }
        }
        public string marks
        {
            set { _marks = value; }
            get { return _marks; }
        }

        public bool isFivesOnly()
        {
            return marks.All(w => w == '5' || w == ' ');
        }

        public Student(string fio, string kurs, string group, string marks) : base(fio)
        {
            this.kurs = kurs;
            this.group = group;
            this.marks = marks;
        }



        public override void Write(System.IO.StreamWriter outputFile)
        {
            base.Write(outputFile);
            outputFile.WriteLine(kurs + " курс, " + group + " группа");
            outputFile.WriteLine(marks);
        }
    }
}
