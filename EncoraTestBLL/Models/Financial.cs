using System;
namespace EncoraTestBLL.Models
{
    public class Financial
    {

        #region class properties

        public int Id { get; set; }

        public float? CapRate { get; set; }

        public string Occupancy { get; set; }

        public bool IsSection8 { get; set; }

        public DateTime? LeaseStartDate { get; set; }

        public DateTime? LeaseEndDate { get; set; }

        public float ListPrice { get; set; }

        public float? SalePrice { get; set; }

        public float? MarketValue { get; set; }

        public float? MonthlyHoa { get; set; }

        public float? MonthlyManagementFees { get; set; }

        public float MonthlyRent { get; set; }

        public float? NetYield { get; set; }

        public float? TurnOverFee { get; set; }

        public float? RehabCosts { get; set; }

        public DateTime? RehabDate { get; set; }

        public float? YearlyInsuranceCost { get; set; }

        public float? YearlyPropertyTaxes { get; set; }

        public bool IsCashOnly { get; set; }

        public float GrossYield { get { return ((MonthlyRent * 12) / ListPrice) * 100; } }

        #endregion


        public Financial()
        {
        }
    }
}
