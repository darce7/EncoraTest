using System;
namespace EncoraTestBLL.Models
{
    public class Photo
    {

        #region class properties

        public int Id { get; set; }

        public Guid Guid { get; set; }

        public string ResourceType { get; set; }

        public bool IsPublic { get; set; }

        public string Description { get; set; }

        public string FileName { get; set; }

        public long SizeInByte { get; set; }

        public string ContentType { get; set; }

        public string Url { get; set; }

        public string UrlMedium { get; set; }

        public string UrlSmall { get; set; }

        public string TextContent { get; set; }

        #endregion

        public Photo()
        {
        }
    }
}
