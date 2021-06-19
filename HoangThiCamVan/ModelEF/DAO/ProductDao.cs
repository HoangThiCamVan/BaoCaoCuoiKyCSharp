using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
    public class ProductDao

    {
        HoangThiCamVanContext db = null;
        public ProductDao()
        {
            db = new HoangThiCamVanContext();
        }
        public List<Product> ListCategory1(int status)
        {
            return db.Products.Where(x => x.ID_Category==1).Take(status).ToList();
        }
        public List<Product> ListCategory2(int status)
        {
            return db.Products.Where(x => x.ID_Category == 2).Take(status).ToList();
        }
        public List<Product> ListCategory3(int status)
        {
            return db.Products.Where(x => x.ID_Category == 3).Take(status).ToList();
        }
        public List<Product> ListCategory4(int status)
        {
            return db.Products.Where(x => x.ID_Category == 4).Take(status).ToList();
        }
        public List<Product> ListCategory7(int status)
        {
            return db.Products.Where(x => x.ID_Category == 7).Take(status).ToList();
        }

        public Product Find(int name)
        {
            return db.Products.Find(name);
        }
      

        //public List<Product> ListAll()
        //{
        //    return db.Products.ToList();
        //}

       


        public bool productDetails(Product entitySP)
        {
            try
            {
                var product = db.Products.Find(entitySP.ID);
                product.Name = entitySP.Name;
                product.UnitCost = entitySP.UnitCost;
                product.Quantity = entitySP.Quantity;
                product.Image = entitySP.Image;
                product.Description = entitySP.Description;
                product.Status = entitySP.Status;
                product.ID_Category = entitySP.ID_Category;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public string Create(Product entityProduct)
        {
            db.Products.Add(entityProduct);
            db.SaveChanges();   
            return entityProduct.Name;
        }

        public IEnumerable<Product> LisWheretAll(string search)
        {
            IQueryable<Product> model = db.Products;
            if (!string.IsNullOrEmpty(search))
            {
                return model.Where(x => x.Name.Contains(search)).OrderBy(x => x.Name) ;
            }
            return model.OrderBy(x => x.Quantity).ThenByDescending(x=>x.UnitCost);
        }

    }
}
