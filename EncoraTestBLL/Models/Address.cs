using System;
namespace EncoraTestBLL.Models
{
    public class Address
    {

        #region class properties

        public int Id { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string County { get; set; }

        public string Distric { get; set; }

        public string State { get; set; }

        public int? Zip { get; set; }

        public string ZipPlus4 { get; set; }

        public string FullAddress { get { return String.Format("{0} {1}, {2}, {3}, {4}", Address1, Address2, City, State, Zip); } }

        #endregion

        public Address()
        {
        }
    }
}
