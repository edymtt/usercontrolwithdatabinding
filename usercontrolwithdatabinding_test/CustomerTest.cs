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
    }
}
