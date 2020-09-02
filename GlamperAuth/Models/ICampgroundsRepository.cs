using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlamperAuthMOD.Models
{
    interface ICampgroundsRepository
    {
        public List<Campgrounds> GetCampgrounds(string selectState);
    }
}
