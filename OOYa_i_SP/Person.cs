using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYa_i_SP
{
    class Person
    {
        protected string _fio; //ФИО.
        public string fio
        {
            set { _fio = value; }
            get { return _fio; }
        }

        public Person(string fio)
        {
            this.fio = fio;
        }

        public virtual void Write(System.IO.StreamWriter outputFile)
        {
            outputFile.WriteLine(fio);
        }

    }
}
