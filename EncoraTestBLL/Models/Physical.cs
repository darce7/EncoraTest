using System;
namespace EncoraTestBLL.Models
{
    public class Physical
    {

        #region class properties

        public int Id { get; set; }

        public float? BathRooms { get; set; }

        public string BedRooms { get; set; }

        public string ParcelNumber { get; set; }

        public bool IsPool { get; set; }

        public float? LotSize { get; set; }

        public float? SquareFeet { get; set; }

        public int? Stories { get; set; }

        public int? Units { get; set; }

        public int? YearBuilt { get; set; }

        public int? ZipYearBuilt { get; set; }

        #endregion

        public Physical()
        {
        }
    }
}
