using NHLSystemClassLibrary;
namespace NHLSystemTest
   
{
    [TestClass]
    public class TeamTest
    {
        [TestMethod]
        [DataRow("Oilers", Conference.Western, Division.Pacific)]
        [DataRow("Flames", Conference.Western, Division.Pacific)]
        [DataRow("Canucks", Conference.Western, Division.Pacific)]
        [DataRow("Maple Leafs", Conference.Eastern, Division.Atlantic)]
        [DataRow("Senators", Conference.Eastern, Division.Atlantic)]
        [DataRow("Canadiéns", Conference.Western, Division.Atlantic)]
        [DataRow("Winipeg", Conference.Western, Division.Atlantic)]

        public void Name_ValidName_NameSet(string teamName)
        {
            //arrange
            //act
            Team currentTeam = new Team(teamName);
            //assert
            Assert.AreEqual(teamName, currentTeam.Name);
        }
        [TestMethod]
        [DataRow("", "Name Cannot Be Blank")]
        [DataRow("      ", "Name Cannot Be Blank")]
        public void Name_InvalidName_ThrowsArgumentNullException(String teamname, string exceptedErrorMessage)
        {
            //arrange an act
            try
            {
                Team currentTeam = new Team(teamname);
                Assert.Fail("An argumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, exceptedErrorMessage);
            }
        }
    }
}