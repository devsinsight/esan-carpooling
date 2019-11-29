using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.DataAccess
{
    public class EmpresaRepository : GenericRepository<Empresa>
    {
        public EmpresaRepository(CarpoolingDbEntities context) : base(context) { }
    }
}
