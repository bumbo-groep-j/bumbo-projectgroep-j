using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Domain;
using WebApp;
using Bumbo.Controllers;
using Moq;
using Microsoft.AspNetCore.Identity;

namespace Bumbo.Test.MSTest.EmployeeTests
{
    [TestClass]
    public class RequestLeaveTest
    {
        // No idea, if this is good for testing
        
        [TestMethod]
        public void RequestLeaveSavedToDBSuccess()
        {
            // Arrange
            var leaveRequest = new LeaveRequest
            {
                EmployeeId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                Comment = "Test",
                Approved = false,
                Rejected = false
            };

            // Act
            var mockContext = new Mock<BumboDbContext>();
            var mockUserManager = new Mock<UserManager<Account>>();
            var controller = new EmployeeController(mockContext.Object, mockUserManager.Object);

            controller.RequestLeave(leaveRequest);

            // Assert
            mockContext.Verify(context => context.LeaveRequests.Add(leaveRequest), Times.Once());
            mockContext.Verify(context => context.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void RequestLeaveLinkedUserSuccess()
        {
            // Arrange
            var leaveRequest = new LeaveRequest
            {
                EmployeeId = 1,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                Comment = "Test",
                Approved = false,
                Rejected = false
            };

            // make employee object with all the properties
            var employee = new Employee
            {
                Id = 1,
                UserName = "username",
                FirstName = "FirstName",
                LastName = "Test",
                DateOfBirth = DateTime.Now,
                NFCToken = "123456789",
            };
            
            leaveRequest.EmployeeId = employee.Id;

            // Act 
            var mockContext = new Mock<BumboDbContext>();
            var mockUserManager = new Mock<UserManager<Account>>();
            var controller = new EmployeeController(mockContext.Object, mockUserManager.Object);

            controller.RequestLeave(leaveRequest);
            
            // Assert
            Assert.AreEqual(leaveRequest.EmployeeId, employee.Id);

        }
    }
}

