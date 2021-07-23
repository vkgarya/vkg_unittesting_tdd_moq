using System;
using System.Collections.Generic;

namespace MoqUnitTestingTrainingApp
{
    public interface IEmployeeBusinessLayer
    {
        IList<Employee> GetEmployeesBL();
    }

    public class EmployeeBusinessLayer : IEmployeeBusinessLayer
    {
        private IEmployeeDataLayer _employeeDataLayer;
        public EmployeeBusinessLayer(IEmployeeDataLayer employeeDataLayer)
        {
            _employeeDataLayer = employeeDataLayer;
        }

        public IList<Employee> GetEmployeesBL()
        {
            IList<Employee> result = null;
            try
            {
                result = _employeeDataLayer.GetEmployeesDL("Admin");
            }
            catch (Exception)
            {
                // Handle & log exception here
            }
            return result;
        }
    }
}
