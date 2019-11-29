using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.DataAccess
{
    public class EmpleadoRepository : GenericRepository<Empleado>
    {
        public EmpleadoRepository(CarpoolingDbEntities context) : base(context) { }
    }
}
