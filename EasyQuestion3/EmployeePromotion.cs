using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyQuestion3
{
    class EmployeePromotion
    {
        List<string> employeeNames = new List<string>();
        string input = "NotEmpty";
        int currentSize,sizeAfterRemovingExtraSpace;

        public void AddEmployeesAccordingToPromotioneligibility()
        {
            try
            {
                Console.WriteLine("Please enter the employee names in the order of their eligibility for promotion(Please enter blank to stop)");
                while (input != String.Empty && input != " ")
                {
                    input = Console.ReadLine();
                    employeeNames.Add(input);
                }
                Console.WriteLine("The employees accoridng to their eligibility for promotion are :");
                foreach (var names in employeeNames)
                {
                    Console.WriteLine(names);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Sorry !! There was an error !! Please Try Again !!");
                Console.WriteLine(e);
                AddEmployeesAccordingToPromotioneligibility();
            }
        }
        public void CheckSizeAndRemoveExtraSpace()
        {
            try
            {
                currentSize = employeeNames.Capacity;
                Console.WriteLine($"The current size of the collection is {currentSize}");
                employeeNames.Remove(" ");
                employeeNames.Remove(String.Empty);
                employeeNames.TrimExcess();
                sizeAfterRemovingExtraSpace = employeeNames.Capacity;
                Console.WriteLine($"The size after removing the extra space is {sizeAfterRemovingExtraSpace}");
            }catch(Exception e)
            {
                Console.WriteLine("Sorry !! There was an error !! Please Try Again !!");
                Console.WriteLine(e);
            }
        }
    }
}
