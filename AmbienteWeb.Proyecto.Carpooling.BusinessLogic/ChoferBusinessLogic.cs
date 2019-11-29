using AmbienteWeb.Proyecto.Carpooling.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.BusinessLogic
{
    public class ChoferBusinessLogic
    {
        private ChoferRepository _choferRepository;

        public ChoferBusinessLogic() {
            _choferRepository = new ChoferRepository( new CarpoolingDbEntities());
        }

        public IEnumerable<Chofer> ObtenerTodos()
        {
            return _choferRepository.Get().ToList();
        }

        public Chofer ObtenerChoferPorId(int? id)
        {
            return _choferRepository.GetByID(id);
        }

        public void ActualizarChofer(Chofer chofer)
        {
            _choferRepository.Update(chofer);
        }

        public void CrearChofer(Chofer chofer)
        {
            _choferRepository.Insert(chofer);
        }
    }
}
