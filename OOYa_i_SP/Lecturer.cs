using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYa_i_SP
{
    class Lecturer:Person
    {
        private string _grade;
        public string grade
        {
            set { _grade = value; }
            get { return _grade; }
        }

        public Lecturer(string fio, string grade):base(fio)
        {
            this.grade = grade;
        }

        public override void Write(System.IO.StreamWriter outputFile)
        {
            base.Write(outputFile);
            outputFile.WriteLine(grade);
        }
    }
}
