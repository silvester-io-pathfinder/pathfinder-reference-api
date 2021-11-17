using NpgsqlTypes;
using System.Linq.Expressions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;


namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Proficiency : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public int Bonus { get; set; }
     
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class ProficiencySearchConfigurator : SearchableEntityConfigurator<Proficiency>
    {
        public override Expression<Func<Proficiency, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name };
        }
    }
}
