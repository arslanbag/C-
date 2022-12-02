using FluentValidation;
using Northwind.Businness.Abstracts.Base;
using Northwind.Businness.Utilities;
using Northwind.Businness.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstracts.Base;
using Northwind.DataAccess.Abstracts.Type;
using Northwind.DataAccess.Concretes.EntityFramework.Type;
using Northwind.Entites.Abstracts;
using Northwind.Entites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Businness.Concretes.Base
{
    public class BaseManagerMethods<TEntity> : IBaseServiceSignature<TEntity>
        where TEntity : class, IGroupEntity, new()
    {
        public IBaseRepositorySignature<TEntity> _repository;
        public IValidator _validator;
    
        //-----------------------------------------------------------
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return _repository.Get(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _repository.GetAll(filter);
        }

        public void Add(TEntity entity)
        {

            ValidationTool.Validate(_validator, entity);
            _repository.Add(entity);
        }

        public void Update(TEntity entity)
        {
            ValidationTool.Validate(_validator, entity);
            _repository.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            ValidationTool.Validate(_validator, entity);
            _repository.Delete(entity);
        }

    }
}
