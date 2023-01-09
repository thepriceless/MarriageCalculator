using System.Collections.Generic;
using MarriageCalculator.Models.Score;

namespace MarriageCalculator.Entities
{
    public class MarriageMatch
    {
        private List<PlayerScore> _scores;

        public MarriageMatch(int numberOfPlayers)
        {
            _scores = new List<PlayerScore>(numberOfPlayers);
        }
    }
}