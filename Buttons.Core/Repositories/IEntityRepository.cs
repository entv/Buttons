using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buttons.Core.Entities;
using Buttons.Core.Exceptions;

namespace Buttons.Core.Repositories
{
    public interface IEntityRepository
    {
        public Entity GetById(int id);
    }

    public class EntityRepository : IEntityRepository 
    {
        private readonly List<Entity> _entitiesList = new List<Entity>
        {
            new Entity(1, "вы нажали кнопку номер 1."),
            new Entity(2, "Ура! Кнопка номер 2 нажата!"),
            new Entity(3, "Три из трех")
        };

        public Entity GetById(int id)
        {
            if (_entitiesList.Exists(entity => entity.Id == id))
            {
                return _entitiesList.Find(entity => entity.Id == id);
            }

            throw new ElementDoesNotExistException();
        }
    }
}
