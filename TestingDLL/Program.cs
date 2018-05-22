using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace TestingDLL
{
    class Program : CT
    {
        
        static void Main(string[] args)
        {
            
            CT.Header("YAY IT WORKED", "To use DLLs");
            CT.AskUserForDouble("a number");
            CT.AnyKeyToContinue();
            Header2();
            CT.Footer();
            
        }
    }
}
