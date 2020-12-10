using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class Program
    {
        static void Main(string[] args)                                 //This is the entry to the application - single responsibility - this class will hold all collections associated with                                                                      the UI
        {
            ProgramUI program = new ProgramUI();
            program.Run();
        }
    }
}
