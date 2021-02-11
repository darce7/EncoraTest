using System;
using System.Linq;
using EncoraTestBLL.Models;

namespace EncoraTestBLL.DLL
{
    public static class PropertyDTO
    {

        public static void saveProperty(Property property)
        {
            using(var db = new EncoraTestContext())
            {
                try
                {
                    db.Add(property);
                    db.SaveChanges();
                }catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

    }
}
