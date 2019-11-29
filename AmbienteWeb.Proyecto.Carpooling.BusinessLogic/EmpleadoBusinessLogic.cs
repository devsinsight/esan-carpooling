using AmbienteWeb.Proyecto.Carpooling.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.BusinessLogic
{
    public class EmpleadoBusinessLogic
    {
        private EmpleadoRepository _empleadoRepository;

        public EmpleadoBusinessLogic() {
            _empleadoRepository = new EmpleadoRepository(new CarpoolingDbEntities());
        }

        public void CrearEmpleado(Empleado empleado) {
            _empleadoRepository.Insert(empleado);
        }

        public Empleado ObtenerEmpleadoPorId(int? id)
        {
            return _empleadoRepository.GetByID(id);
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            _empleadoRepository.Update(empleado);
        }

        public IEnumerable<Empleado> ObtenerTodos(int empresaId)
        {
            return _empleadoRepository.Get( x => x.EmpresaId == empresaId).ToList();
        }
    }
}
