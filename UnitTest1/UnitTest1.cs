using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EnterFirstName entername = new EnterFirstName();

            string value = "pratik";
            bool match = entername.ValidName(value);
           
            Assert.IsTrue(match);

           
            EnterLastName enterlastname = new EnterLastName();
           
            string value1 = "chitruk";
            bool match1 = enterlastname.ValidName(value1);
           
            Assert.IsTrue(match1);

            MobileNo enterno = new MobileNo();



            string value2 = "8208508814";
            bool match2 = enterno.ValidNo(value2);

            Assert.IsTrue(match2);

            Email enteremail = new Email();
            string value3 = "pratik.chitruk@gmail.com";
            bool match3 = enteremail.ValidEmail(value3);

            Assert.IsTrue(match3);

            Password password = new Password();



            string value4 = "1234567890";
            bool match4 = password.ValidNo(value4);
            Assert.IsTrue(match4);

            AddUpeer addupeer = new AddUpeer();



            string value5 = "1234567891P";
            bool match5 = addupeer.ValidNo(value5);
            Assert.IsTrue(match5);


            Addspacial addspacial = new Addspacial();



            string value6 = "1234567891@P";
            bool match6 = addspacial.ValidNo(value6);
            Assert.IsTrue(match6);


















        }
    }
}