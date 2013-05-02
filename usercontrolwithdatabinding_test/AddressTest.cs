using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using usercontrolwithdatabinding.Model;

namespace usercontrolwithdatabinding_test
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        public void TestStreetError()
        {
            var addr=new Address();
            var errorInfo=addr as System.ComponentModel.IDataErrorInfo;

            Assert.IsTrue(String.IsNullOrWhiteSpace(errorInfo["Street"]));

            addr.Street="error";
             Assert.IsFalse(String.IsNullOrWhiteSpace(errorInfo["Street"]));
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


       
    }
}
