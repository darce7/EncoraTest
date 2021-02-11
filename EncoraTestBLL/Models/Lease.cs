using System;
namespace EncoraTestBLL.Models
{
    public class Lease
    {

        #region class properties

        public int Id { get; set; }

        public LeaseSummary LeaseSummary { get; set; }

        public UtilitiesOwnership UtilitiesOwnership { get; set; }

        public ApplianceOwnership ApplianceOwnership { get; set; }

        #endregion

        public Lease()
        {
        }
    }
}
