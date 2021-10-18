using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buttons.Core.Entities
{
    public class Entity
    {
        public int Id { get; }
        public string Text { get; }

        public Entity(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}
