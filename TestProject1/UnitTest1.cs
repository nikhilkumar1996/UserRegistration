using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressions;

namespace TestProject1
{
    public class Tests
    {
        [TestClass]
        public class UnitTest1
        {
            //validation for first Name
            [TestMethod]
            [DataRow("Nikhil", "Nikhil")]
            [DataRow("Nik", "Nik")]
            [DataRow("N", null)]
            [DataRow("Nikhil05", null)]

            public void ValidateFirstname(string a, string expected)
            {
                    var actual = RegexSample.ValidatingFirstName(a);
                    Assert.AreEqual(expected, actual);
                
            }
            //Validating for Last Name
            [TestMethod]
            [DataRow("Kumar", "Kumar")]
            [DataRow("Ku", null)]
            [DataRow("kumar", "kumar")]
            [DataRow("Kumar05", null)]
            public void ValidateUserLastname(string a, string expected)
            {
                var actual = RegexSample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            //Validation for Email
            [TestMethod]
            [DataRow("abc@gmail.com", "abc@gmail.com")]
            [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
            [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
            [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
            [DataRow("abc111@abc.com", "abc111@abc.com")]
            [DataRow("abc-100@abc.net", "abc-100@abc.net")]
            [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
            [DataRow("abc@1.com", "abc@1.com")]
            [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
            [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
            [DataRow("abc", null)]
            [DataRow("abc@.com.my", null)]
            [DataRow("abc123@.com", null)]
            [DataRow("abc123@.com.com", null)]
            [DataRow("abc()*@gmail.com", null)]
            [DataRow(".abc@abc.com", null)]
            [DataRow("abc@%*.com", null)]
            [DataRow("abc..2002@gmail.com", null)]
            [DataRow("abc.@gmail.com", null)]
            [DataRow("abc@abc@gmail.com", null)]
            [DataRow("abc@gmail.com.1a", null)]
            [DataRow("abc@gmail.com.aa.au", null)]

            public void ValidateUserEmail(string a, string expected)
            {
                    var actual = RegexSample.ValidatingEmailId(a);
                    Assert.AreEqual(expected, actual);
                
            }

            //Validation for Phone Number
            [TestMethod]
            [DataRow("1 1000987267", "1 1000987267")]
            [DataRow("91 9842905050", "91 9842905050")]
            [DataRow("100 9842905050", "100 9842905050")]
            [DataRow("919842905050", null)]
            [DataRow("919842905", null)]
            [DataRow("91 984290", null)]
            [DataRow("91 984290505000000", null)]
            public void ValidateUserPhoneNumber(string a, string expected)
            {
                
                    var actual = RegexSample.ValidatingPhoneNum(a);
                    Assert.AreEqual(expected, actual);
            }

            ////Validation for Password
            [TestMethod]
            [DataRow("Nike@123", "Nike@123")]
            [DataRow("Nike#23", "Nike#123")]
            [DataRow("Ni@ke1S ", "Ni@ke1S")]
            [DataRow("@Nike453", "@Nike453")]
            [DataRow("Ni-ke123", "Ni-ke123")]
            [DataRow("Nike123)@1234", null)]
            [DataRow("Ni@ke", null)]
            [DataRow("Ni123", null)]
            [DataRow("Nik@123", null)]
            [DataRow("@ni#12kr", null)]
            [DataRow(")nikeh12", null)]
            [DataRow(")nikhil12", null)]
            [DataRow("nik-ik@12S", null)]
            [DataRow("niked@s", null)]

            public void ValidateUserPassword(string a, string expected)
            {
                
                var actual = RegexSample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);    
            }
            [TestMethod]
            public void Test_Method_Object_Creation_RegexSample()
            {
                object expected = new RegexSample();
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object actual = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSample");
                expected.Equals(actual);

            }
            //Test for parameterconstructor invoked using object created
            [TestMethod]
            public void Test_Method_Parameteized_Constructor()
            {
                object expected = new RegexSample("RegularExpression");
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object actual = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSample", "RegularExpression");
                actual.Equals(expected);
            }

            [TestMethod]
            public void Reflection_Return_Default_Constructor_No_Constructor_Found()
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object expected = new RegexSample();
                object obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSam");
                var expectedType = expected.GetType();
                var objType = obj.GetType();
                Assert.AreEqual(expectedType, objType);
                
                 
            }
            [TestMethod]
            public void Reflection_Return_Default_Constructor_No_Class_Found()
            {
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object expected = new RegexSample();
                object obj = factory.CreateObjectForRegexSample("UserRegistration.RegexSample", "RegexSample");
                var expectedType = expected.GetType();
                var objType = obj.GetType();
                Assert.AreEqual(expectedType, objType);


            }
            [TestMethod]
            public void Reflection_Return_Parameterized_Class_Invalid()
            {
                string message = "Regular Expression";
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object expected = new RegexSample();
                object obj = factory.CreateParameterizedConstructor("UserRegistration.RegexSae", "RegexSample", message);
                var expectedType = expected.GetType();
                var objType = obj.GetType();
                Assert.AreEqual(expectedType, objType);
            }

            [TestMethod]
            public void Reflection_Return_Parameterized_Constructor_Invalid()
            {
                string message = "Regular Expression";
                UserRegistrationFactory factory = new UserRegistrationFactory();
                object expected = new RegexSample();
                object obj = factory.CreateParameterizedConstructor("UserRegistration.RegexSample", "RegexSam", message);
                var expectedType = expected.GetType();
                var objType = obj.GetType();
                Assert.AreEqual(expectedType, objType);
               
            }


        }

    }
}