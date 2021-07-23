using System.Collections.Generic;

namespace MoqUnitTestingTrainingApp
{
    public interface IEmployeeDataLayer
    {
        IList<Employee> GetEmployeesDL(string departmentName);
    }
    public class EmployeeDataLayer : IEmployeeDataLayer
    {
        public IList<Employee> GetEmployeesDL(string departmentName)
        {

            // Consider this data is coming from Database/API call
            return new List<Employee> { new Employee { EmpName = "Vijay" } };
        }
    }
}

