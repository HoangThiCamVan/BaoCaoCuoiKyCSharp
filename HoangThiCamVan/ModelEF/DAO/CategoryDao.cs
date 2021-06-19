using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
   public class CategoryDao
    {
        HoangThiCamVanContext db = null;
        public CategoryDao()
        {
            db = new HoangThiCamVanContext();
        }

        public Category Find(string ID)
        {
            return db.Categories.Find(ID);
        }
        public List<Category> ListAll()
        {
            return db.Categories.ToList();
        }
    }
}
