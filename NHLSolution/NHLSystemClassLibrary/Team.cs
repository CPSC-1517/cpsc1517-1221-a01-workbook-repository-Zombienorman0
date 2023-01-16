using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLSystemClassLibrary
{

    internal class Team
    {
        string name;
        string City;
        string Arena;
        Conference conference;
        Division division;

        public class TeamS
        {
            Conference _conference;
            Division _division;
            string _name;
            string _city;
            string _arena;


            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException(nameof(Name), "Name Cannot Be Blank");
                    }
                    _name = value.Trim();
                }
            }

            public Conference Conference { get; set; }
            public Division Division { get; set; }


            public TeamS(string Name, Conference conference, Division division)
            {
                this.Name = Name;
                Conference = conference;
                Division = division;
            }
        }
    }
}
