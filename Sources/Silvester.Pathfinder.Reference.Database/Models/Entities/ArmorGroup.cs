using NpgsqlTypes;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class ArmorGroup : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public string ArmorSpecializationEffect { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public ICollection<Armor> Armors { get; set; } = new List<Armor>();
        
        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }
}
