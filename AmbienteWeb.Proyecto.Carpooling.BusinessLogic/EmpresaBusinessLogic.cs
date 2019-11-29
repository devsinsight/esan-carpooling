using AmbienteWeb.Proyecto.Carpooling.DataAccess;
using System;
using System.Linq;

namespace AmbienteWeb.Proyecto.Carpooling.BusinessLogic
{
    public class EmpresaBusinessLogic
    {
        private EmpresaRepository _empresaRepository;

        public EmpresaBusinessLogic()
        {
            _empresaRepository = new EmpresaRepository(new CarpoolingDbEntities());
        }

        public void CrearEmpresa(string razonSocial, string ruc, Guid userId) {
            var empresa = new Empresa
            {
                RazonSocial = razonSocial,
                RUC = ruc ,
                UserId = userId
            };

            _empresaRepository.Insert(empresa);
        }

        public void ActualizarEmpresaPorUserId(Guid userId, decimal? longitude, decimal? latitude)
        {
            var empresa = _empresaRepository.Get(x => x.UserId == userId).FirstOrDefault();
            empresa.Longitude = longitude;
            empresa.Latitude = latitude;
            _empresaRepository.Update(empresa);
        }

        public Empresa ObtenerEmpresaPorUserId(string value)
        {
            return _empresaRepository.Get(x => x.UserId.ToString() == value).ToList().FirstOrDefault();

        }
    }
}
