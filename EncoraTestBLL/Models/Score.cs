using System;
namespace EncoraTestBLL.Models
{
    public class Score
    {

        #region class properties

        public int Id { get; set; }

        public int? ConditionScore { get; set; }

        public string CrimeScore { get; set; }

        public int? NeighborhoodScore { get; set; }

        public int? OverallScore { get; set; }

        public int? QualityScore { get; set; }

        public string SchoolScore { get; set; }

        public int? FloodRiskScore { get; set; }

        public int? WalkabilityScore { get; set; }

        #endregion

        public Score()
        {
        }
    }
}
