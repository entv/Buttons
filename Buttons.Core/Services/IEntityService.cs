using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buttons.Core.Entities;
using Buttons.Core.Exceptions;
using Buttons.Core.Models;
using Buttons.Core.Repositories;

namespace Buttons.Core.Services
{
    public interface IEntityService
    {
        public Entity GetByQuery(string query);
    }

    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _repository;

        public EntityService(IEntityRepository repository)
        {
            _repository = repository;
        }

        public Entity GetByQuery(string query)
        {
            if (int.TryParse(query, out int id))
            {
                return _repository.GetById(id);
            }

            throw new BadQueryException();
        }
    }
}
