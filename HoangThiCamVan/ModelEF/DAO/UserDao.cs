using ModelEF.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEF.DAO
{
   public class UserDao
    {
        private HoangThiCamVanContext db;
        public UserDao()
        {
            db = new HoangThiCamVanContext();

        }

    
        public int login(string user,string pass,string status)
        {
            status = "Activated";
            var result = db.UserAccounts.SingleOrDefault(x => x.UserName.Contains(user) && x.Password.Contains(pass) && x.Status.Contains(status));
            if (result == null)
            {
                return 0;
            }
            else { return 1; }
        }
        
       

        //public UserAccount Find(string username)
        //{
        //    return db.UserAccounts.Find(username);
        //}
        //public List<UserAccount> ListAll()
        //{
        //    return db.UserAccounts.ToList();
        //}

        public IEnumerable<UserAccount> ListWhereAll(string keysearch, int page, int pagesize)
        {
            IQueryable<UserAccount> model = db.UserAccounts;
            if (!string.IsNullOrEmpty(keysearch))
            {
                model = model.Where(x => x.Status.Contains(keysearch) || x.UserName.Contains(keysearch));
            }
            return model.OrderBy(x => x.ID).ToPagedList(page, pagesize);
        }

        public bool Delete(int id)
        {
            try
            {
                var user = db.UserAccounts.Find(id);
                db.UserAccounts.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
