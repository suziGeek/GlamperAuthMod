using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlamperAuthMOD.Models
{
    interface ICampsiteDetailRepository
    {
        CampsiteDetail GetCamperDetail(string campId, string contractId);
    }
}
