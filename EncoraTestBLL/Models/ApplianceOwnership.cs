using System;
namespace EncoraTestBLL.Models
{
    public class ApplianceOwnership
    {

        #region class properties

        public int Id { get; set; }

        public string Refrigerator { get; set; }

        public string Dishwasher { get; set; }

        public string Washer { get; set; }

        public string Dryer { get; set; }

        public string Microwave { get; set; }

        public string Stove { get; set; }

        #endregion

        public ApplianceOwnership()
        {
        }
    }
}
