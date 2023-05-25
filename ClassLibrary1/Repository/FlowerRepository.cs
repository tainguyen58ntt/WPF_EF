using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class FlowerRepository : IFlowerRepository

    {
        public bool DeleteFlower(FlowerBouquet flowerBouquet) => FlowerManagement.Instance.Remmove(flowerBouquet);







        public List<FlowerBouquet> GetFlowerBouquets()
        {
            return FlowerManagement.Instance.GetFlowerBouquets();
        }

        public List<FlowerBouquet> GetFlowerBouquetsByName(string name)
        {
            return FlowerManagement.Instance.GetFlowerBouquetsByName(name);
        }

        public FlowerBouquet GetObjetByFlId(FlowerBouquet flowerBouquet)
        {
            return FlowerManagement.Instance.GetFlowerByFlID(flowerBouquet);
        }

        public void InserFlower(FlowerBouquet flowerBouquet) => FlowerManagement.Instance.AddNew(flowerBouquet);

        public void Update(FlowerBouquet flowerBouquet) => FlowerManagement.Instance.Update(flowerBouquet);

    }
}
