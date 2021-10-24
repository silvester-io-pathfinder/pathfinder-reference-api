using NpgsqlTypes;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Stat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Class> KeyAbilityClasses { get; set; } = new List<Class>();

        public ICollection<Skill> Skills { get; set; } = new List<Skill>();
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
