using NpgsqlTypes;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Stat : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Class> KeyAbilityClasses { get; set; } = new List<Class>();

        public ICollection<Skill> Skills { get; set; } = new List<Skill>();

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class StatSearchConfigurator : SearchableEntityConfigurator<Stat>
    {
        public override Expression<Func<Stat, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Abbreviation };
        }
    }
}
