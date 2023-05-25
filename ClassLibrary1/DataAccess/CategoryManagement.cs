using ClassLibrary1.BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataAccess
{
    public class CategoryManagement
    {
        private static CategoryManagement instance = null;
        private static readonly object instanceLock = new object();
        private CategoryManagement() { }
        public static CategoryManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryManagement();
                    }
                    return instance;
                }
            }
        }

        //using singleton pattern
        ///
        public List<Category> GetCategories()
        {
            List<Category> categories;
            try
            {
                var myStockDB = new FUFlowerBouquetManagementContext();
                categories = myStockDB.Categories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }
    }
}
