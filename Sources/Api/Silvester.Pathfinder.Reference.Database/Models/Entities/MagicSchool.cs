using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class MagicSchool : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Abbreviation { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Spell> Spells { get; set; } = new List<Spell>();

        public Guid? RuneMagicSchoolId { get; set; }
        public RuneMagic? RuneMagicSchool { get; set; } 

        public ICollection<RuneMagicSchoolBinding> ProibitedByRuneMagic { get; set; } = new List<RuneMagicSchoolBinding>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class MagicSchoolSearchConfigurator : SearchableEntityConfigurator<MagicSchool>
    {
        public override Expression<Func<MagicSchool, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description, e.Abbreviation };
        }
    }
}
