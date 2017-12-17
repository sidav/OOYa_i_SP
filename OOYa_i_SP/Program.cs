using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOYa_i_SP
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty testFaculty = new Faculty();
            testFaculty.sortPersons();
            testFaculty.writePersons();
            testFaculty.writeFivesOnly();

            testFaculty = null;
            GC.Collect(); //VERY BAD IDEA

        }
    }
}
