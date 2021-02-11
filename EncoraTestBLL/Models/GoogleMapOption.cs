using System;
namespace EncoraTestBLL.Models
{
    public class GoogleMapOption
    {

        #region class properties

        public int Id { get; set; }

        public bool HasStreeView { get; set; }

        public int PovHeading { get; set; }

        public int PovPitch { get; set; }

        public long PovLatitude { get; set; }

        public long PovLongitude { get; set; }

        #endregion

        public GoogleMapOption()
        {
        }
    }
}
