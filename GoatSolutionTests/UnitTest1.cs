using GoatSolution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoatSolutionTests
{
    [TestClass]
    public class UnitTest1
    {
           private Solution_Goat goat;

            [TestInitialize]
            public void Setup()
            {
                goat = new Solution_Goat();
            }

            [TestMethod]
            [DataRow("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
            [DataRow("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
            public void Should_A_String_IsGoatLatin(string input, string expected)
            {
                //Act
                string actual = goat.ToGoatLatin(input);

                //Assert
                Assert.AreEqual(expected, actual);
            }
    }

 }



