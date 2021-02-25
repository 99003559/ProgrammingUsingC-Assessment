using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
   public class Manager :Employee
    {
        private static int eID;
        private static string eName;
        private static int eLevel;
        private static DateTime eDoJ;
        private List<Employee> lstDirectReports;
        private string v;

        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpLevel { get; set; }


        public Manager(List<Employee> drEmployeesLst, string cCode) :base(eID, eName, eLevel, eDoJ)
        {
            EmpID = eID;
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public Manager(int eID, string eName, int eLevel, DateTime eDoJ, List<Employee> lstDirectReports, string v) : base(eID, eName, eLevel, eDoJ)
        {
            this.lstDirectReports = lstDirectReports;
            this.v = v;
        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}

