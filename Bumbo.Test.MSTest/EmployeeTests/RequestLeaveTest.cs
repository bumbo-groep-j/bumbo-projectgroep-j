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
        [TestMethod]
        public void RequestLeaveSavedToDB_Succes()
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
    }
}
