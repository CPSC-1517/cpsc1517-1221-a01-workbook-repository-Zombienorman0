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
        [DataRow("Winipeg", Conference.Western, Division.Central)]

        public void Name_ValidName_NameSet(string teamName, Conference conference, Division division)
        {
            //arrange
            //act
            Team currentTeam = new Team(teamName, conference,division);
            //assert
            Assert.AreEqual(teamName, currentTeam.Name);
            Assert.AreEqual(conference, currentTeam.Conference);
            Assert.AreEqual(division, currentTeam.Division);
        }
        [TestMethod]
        [DataRow("", "Name Cannot Be Blank", Conference.Western, Division.Pacific)]
        [DataRow("      ", "Name Cannot Be Blank", Conference.Western, Division.Pacific)]
        public void Name_InvalidName_ThrowsArgumentNullException(String teamname, string exceptedErrorMessage, Conference conference, Division division)
        {
            //arrange an act
            try
            {
                Team currentTeam = new Team(teamname, conference, division);
                Assert.Fail("An argumentNullException should have been thrown");
            }
            catch(ArgumentNullException ex)
            {
                StringAssert.Contains(ex.Message, exceptedErrorMessage);
            }
        }
    }
}