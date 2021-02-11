using System;
using System.Collections.Generic;

namespace EncoraTestBLL.Models
{
    public class Resource
    {

        #region class properties

        public int Id { get; set; }

        public List<Photo> Photos { get; set; }

        public List<Photo> FloorPlans { get; set; }

        public List<ThreeDRendering> ThreeDRenderings { get; set; }

        public List<Audio> Audios { get; set; }

        #endregion

        public Resource()
        {
        }
    }
}
