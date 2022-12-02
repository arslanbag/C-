using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    internal class NhQueryableRepository<T> : IQueryableRepository<T>
        where T : class, IEntity, new()
    {
        private NhHelper _nhHelper;
        private IQueryable<T> _entities;

        public NhQueryableRepository(NhHelper nhHelper)
        {
            _nhHelper = nhHelper;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual IQueryable<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _nhHelper.OpenSession().Query<T>();

                return _entities;
            }
        }
    }
}
