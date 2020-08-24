using ASPNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlamperAuth.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        //public XElement GetCampDetail();
        //public void UpdateProduct(Product product);
        //public void InsertProduct(Product productToInsert);
        //public IEnumerable<Category> GetCategories();
        //public Product AssignCategory();
        public void DeleteFavorite(Favorites favorite);
        public IEnumerable<Product> GetAllFavorites(string user);
        public void InsertFavorite(uint facilityID, string facilityName, string user);

    }
}
