using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlamperAuth.Models
{
    public interface IFavoritesRepository
    {

        public IEnumerable<Favorites> GetAllFavorites();
       
        
    }
}
