using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Alignment : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public ICollection<Deity> Deities { get; set; } = new List<Deity>();
        public ICollection<Deity> DeityFollowerAlignments { get; set; } = new List<Deity>();
        public ICollection<Plane> Planes { get; set; } = new List<Plane>();
        public ICollection<Artifact> Artifacts { get; set; } = new List<Artifact>();
        public ICollection<Cause> Causes { get; set; } = new List<Cause>();
        public ICollection<Eidolon> Eidolons { get; set; } = new List<Eidolon>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class AlignmentSearchConfigurator : SearchableEntityConfigurator<Alignment>
    {
        public override Expression<Func<Alignment, object?>> GetSearchProperties()
        {
            return (e) => new { e.Name, e.Description };
        }
    }
}
