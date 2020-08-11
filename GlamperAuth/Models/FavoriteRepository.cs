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
    public class FavoriteRepository : IFavoritesRepository
    {
        private readonly IDbConnection _conn;

        

        public FavoriteRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Favorites> GetAllFavorites()
        {
            return _conn.Query<Favorites>("SELECT * FROM Favorites; ");
        }

        public void InsertFavorite(Favorites favoriteToInsert)
        {
            _conn.Execute("INSERT INTO Favorites (userid) VALUES (@id);",
                new { userid = favoriteToInsert.id});

        }


      
    }
}
