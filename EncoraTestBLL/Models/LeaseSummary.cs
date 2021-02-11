using System;
namespace EncoraTestBLL.Models
{
    public class LeaseSummary
    {

        #region class properties

        public int Id { get; set; }

        public string Occupancy { get; set; }

        public string LeasingStatus { get; set; }

        public string MarketedRent { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime? LeaseStartDate { get; set; }

        public DateTime? LeaseEndDate { get; set; }

        public float? MonthlyRent { get; set; }

        public float? SecurityDepositAmount { get; set; }

        public bool? IsPetsDeposit { get; set; }

        public float? PetsDepositAmount { get; set; }

        public bool? IsLeaseConcessions { get; set; }

        public bool? IsRentersInsuranceRequired { get; set; }

        public bool? IsSection8 { get; set; }

        public bool? IsTenantBackgroudChecked { get; set; }

        public bool? IsTenantIncomeAbove3x { get; set; }

        public bool? IsTenantMayTerminateEarly { get; set; }

        public bool? IsTenantPurchaseOption { get; set; }

        #endregion

        public LeaseSummary()
        {
        }
    }
}
