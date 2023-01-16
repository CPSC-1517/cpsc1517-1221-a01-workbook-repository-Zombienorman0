// See https://aka.ms/new-console-template for more information
using NHLSystemClassLibrary;

//Prompt and read in the team name
Console.Write("Enter the team name: ");
string TeamName = Console.ReadLine();
try
{
    //create a new team instance
    Team currentTeam = new Team(TeamName, Conference.Western, Division.Pacific);
    // Print the Team name
    Console.WriteLine($"Team Name: {currentTeam.Name}");
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch
{
    Console.WriteLine("Incorrect exception thrown");
}

