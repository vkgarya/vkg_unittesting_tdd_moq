using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace MoqUnitTestingTrainingApp.Test
{
    [TestClass]
    public class EmployeeBusinessLayerTest
    {
        private Mock<IEmployeeDataLayer> _mockEmployeeData;
        [TestInitialize]
        public void Setup()
        {
            _mockEmployeeData = new Mock<IEmployeeDataLayer>();
        }

        [TestMethod]
        public void VerifyGetEmployeesMethodShouldReturnEmplpoyeeData_Success()
        {
            // Prepare Mock Data
            List<Employee> mockEmployees = new List<Employee> {
                new Employee { EmpName = "Mock Employee Name 0" },
                new Employee { EmpName = "Mock Employee Name 1" }
            };
            // Setup
            _mockEmployeeData.Setup(x => x.GetEmployeesDL(It.IsAny<string>())).Returns(mockEmployees);

            // Arrage
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer(_mockEmployeeData.Object);
            // Act
            var result = employeeBusinessLayer.GetEmployeesBL();
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Mock Employee Name 0", result[0].EmpName);
            Assert.AreEqual("Mock Employee Name 1", result[1].EmpName);
        }

        [TestMethod]
        public void VerifyGetEmployeesMethodShouldReturnEmplpoyeeData_Exception()
        {
            // Setup
            _mockEmployeeData.Setup(x => x.GetEmployeesDL(It.IsAny<string>())).Throws(new Exception("Some Exception"));

            // Arrage
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer(_mockEmployeeData.Object);
            // Act
            var result = employeeBusinessLayer.GetEmployeesBL();
            // Assert
            Assert.IsNull(result);
        }
    }
}
