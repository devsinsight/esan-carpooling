using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.DataAccess
{
    public class ChoferRepository : GenericRepository<Chofer>
    {
        public ChoferRepository(CarpoolingDbEntities context) : base(context) { }
    }
}
