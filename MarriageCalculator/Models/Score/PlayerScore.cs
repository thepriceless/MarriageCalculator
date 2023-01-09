using System.Collections.Generic;

namespace MarriageCalculator.Models.Score
{
    public class PlayerScore
    {
        private List<PlayerScore> _whists;

        public PlayerScore()
        {
            
        }

        public int Heap { get; }
        public int Pool { get; }
    }
}