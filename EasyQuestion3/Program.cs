using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeePromotion employeePromotion = new EmployeePromotion();
            employeePromotion.AddEmployeesAccordingToPromotioneligibility();
            employeePromotion.CheckSizeAndRemoveExtraSpace();
            Console.ReadKey();
        }
    }
}
