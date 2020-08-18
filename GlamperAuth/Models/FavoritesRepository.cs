using ASPNET.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace GlamperAuth.Models
{
    public class FavoritesRepository : IFavoritesRepository
    {
        private readonly IDbConnection _conn;

        

        public FavoritesRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Favorites> GetAllFavorites()
        {
            return _conn.Query<Favorites>("SELECT * FROM Favorites WHERE @user = user; ");
        }

        


      
    }
}
