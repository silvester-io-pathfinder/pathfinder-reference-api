using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Models.Entities
{
    public class Innovation : BaseEntity, ISearchableEntity, INamedEntity
    {
        public string Name { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; } 

        public Guid? TableId { get; set; }
        public Table? Table { get; set; } 

        public ICollection<TextBlock> Details { get; set; } = new List<TextBlock>();

        public ICollection<InnovationModification> Modifications { get; set; } = new List<InnovationModification>();

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class InnovationModification : BaseEntity
    {
        public string Name { get; set; } = default!;

        public string Description { get; set; } = default!;

        public Guid TypeId { get; set; }
        public InnovationModificationType Type { get; set; } = default!;

        public Guid SourcePageId { get; set; }
        public SourcePage SourcePage { get; set; } = default!;

        public Guid InnovationId { get; set; }
        public Innovation Innovation { get; set; } = default!;

        public Guid? EffectId { get; set; }
        public BooleanEffect? Effect { get; set; }

        public Guid? PrerequisiteId { get; set; }
        public BooleanPrerequisite? Prerequisite { get; set; }

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class InnovationModificationType : BaseEntity
    {
        public string Name { get; set; } = default!;
        
        public ICollection<InnovationModification> Modifications { get; set; } = new List<InnovationModification>();
    }
}
 