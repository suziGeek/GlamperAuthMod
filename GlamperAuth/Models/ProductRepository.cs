﻿using ASPNET.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using CodeBeautify;
using GlamperAuthMOD.Models;

namespace GlamperAuth.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM horse_activiy_api");
        }

        public Product GetProduct(int id)
        {
            return (Product)_conn.QuerySingle<Product>("SELECT * FROM horse_activiy_api WHERE facilityId = @id",
                new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
                new { name = product.facilityName, price = product.facilityID, id = product.facilityID });
        }

      
       
        public void InsertFavorite(uint id, string facilityName, string user)
        {
            _conn.Execute("INSERT INTO Favorites (campId, campsiteName, user) VALUES (@id, @facilityName, @user);",
                new { id = id, facilityName= facilityName, user = user });

        }
        //-----parse xml camping detail page

        //public object GetDetail(string jsonString)
        //{
        //    var welcome2 = Welcome2.FromJson(jsonString);

        //    return welcome2;
        //}

    }
}
