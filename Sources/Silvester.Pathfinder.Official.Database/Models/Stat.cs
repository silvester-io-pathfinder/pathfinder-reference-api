using Silvester.Pathfinder.Official.Database;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Models
{
    public class Stat : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;

        public ICollection<Class> KeyAbilityClasses { get; set; } = new List<Class>();
    }
}
