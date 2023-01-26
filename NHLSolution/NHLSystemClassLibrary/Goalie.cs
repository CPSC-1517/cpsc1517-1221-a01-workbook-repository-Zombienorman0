using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NHLSystemClassLibrary
{
    /*
    public class Goalie : Player
    {
        private int _playerNo, _gamesPlayed, _goals, _assists;
        private string _name, _playerName;
        const int MinPlayerNo = 1;
        const int MaxPlayerNo = 98;

        public Goalie(int playerNo, string name, Position position, int gamesPlayed, int goals, int assists)
        {
            PlayerNo = playerNo;
            Name = name;
            Position = position;
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
        }

        public Position Position { get; set; }

        public int PlayerNo
        {
            get => _playerNo;
            private set
            {
                if (value < MinPlayerNo || value > MaxPlayerNo)
                {
                    throw new ArgumentException($"PlayerNo must be between {MinPlayerNo} and {MaxPlayerNo}");
                }
                _playerNo = value;
            }
        }
        public string Name
        {
            get => _playerName;
            set
            {
                if ((value.All(char.IsLetter) || value.Any(char.IsWhiteSpace)) && !string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be blank");
                }
                else
                {
                    throw new Exception("Name must contain only letters and spaces");
                }
                _playerName = value;
            }
        }

        //public Position Position { get; private set; }





        public int GamesPlayed
        {
            get => _gamesPlayed;
            set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException(nameof(value), "Games played cannot be less than 0");
                }
            }
        }
        public int Goals
        {
            get => _goals;
            set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentException(nameof(value), "Goals cannot be less than 0");
                }
            }
        }

        public int Assists
        {
            get => _assists;
            set
            {
                if (!Utilities.IsPositiveOrZero(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Assists cannot be less than 0");
                }
                else
                {
                    _assists = value;
                }
            }
        }

        public int Points => Goals + Assists;
        public void AddGamesPlayed()
        {
            GamesPlayed += 1;
        }
        //METHODS
        public void AddGoal()
        {
            _goals += 1;
        }

        public void AddAssist()
        {
            _assists += 1;
        }
    }*/
}
