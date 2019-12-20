using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReverse;

namespace StringTests
{
    [TestClass]
    public class UnitTest1
    {
        private StringsReverse stu;

       [TestInitialize]
       public void Setup()
        {
            stu = new StringsReverse();
        }
       
        [TestMethod]   
        [DataRow("ab - cd", "dc-ba")]
        [DataRow("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [DataRow("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        public void Should_A_String_IsEqual(string input,string expected)
        {


            //Act
            string actual = stu.ReverseString(input);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
