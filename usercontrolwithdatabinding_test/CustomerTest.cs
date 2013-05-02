using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using usercontrolwithdatabinding.Model;

namespace usercontrolwithdatabinding_test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestTitleError()
        {
            var cust=new Customer();
            var errorInfo=cust as System.ComponentModel.IDataErrorInfo;

            Assert.IsTrue(String.IsNullOrWhiteSpace(errorInfo["Title"]));

            cust.Title="error";
             Assert.IsFalse(String.IsNullOrWhiteSpace(errorInfo["Title"]));
        }

        [TestMethod]
        public void TestFirstNameError()
        {
            var cust = new Customer();
            var errorInfo = cust as System.ComponentModel.IDataErrorInfo;

            Assert.IsTrue(String.IsNullOrWhiteSpace(errorInfo["FirstName"]));

            cust.FirstName = "error";
            Assert.IsFalse(String.IsNullOrWhiteSpace(errorInfo["FirstName"]));
        }

        [TestMethod]
        public void TestLastNameError()
        {
            var cust = new Customer();
            var errorInfo = cust as System.ComponentModel.IDataErrorInfo;

            Assert.IsTrue(String.IsNullOrWhiteSpace(errorInfo["LastName"]));

            cust.LastName = "error";
            Assert.IsFalse(String.IsNullOrWhiteSpace(errorInfo["LastName"]));
        }
    }
}
