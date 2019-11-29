using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmbienteWeb.Proyecto.Carpooling.DataAccess
{
    public class UnitOfWork
    {
        public CarpoolingDbEntities context;

        public UnitOfWork(CarpoolingDbEntities context)
        {
            this.context = context;
        }

        public void Commit() => context.SaveChanges();

        public async Task CommitAsync() => await context.SaveChangesAsync();

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed && disposing)
                context.Dispose();

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
