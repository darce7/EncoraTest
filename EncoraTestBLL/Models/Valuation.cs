using System;
namespace EncoraTestBLL.Models
{
    public class Valuation
    {

        #region class properties

        public int Id { get; set; }

        public float? AvmBpoValue { get; set; }

        public float? AvmBpoAdjValue { get; set; }

        public DateTime? AvmBpoDate { get; set; }

        public float? RsAvmValue { get; set; }

        public DateTime? RsAvmDate { get; set; }

        public float? RsBpoMergeValue { get; set; }

        #endregion

        public Valuation()
        {
        }
    }
}
