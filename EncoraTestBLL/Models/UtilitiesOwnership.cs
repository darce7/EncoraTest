using System;
namespace EncoraTestBLL.Models
{
    public class UtilitiesOwnership
    {

        #region class properties

        public int Id { get; set; }

        public string Electric { get; set; }

        public string Gas { get; set; }

        public string Water { get; set; }

        public string Garbage { get; set; }

        public string Pool { get; set; }

        public string Landscaping { get; set; }

        public string PestControl { get; set; }

        #endregion

        public UtilitiesOwnership()
        {
        }
    }
}
