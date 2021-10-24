using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits
{
    public abstract class Template : EntityTemplate<Trait>
    {
        protected override Trait GetEntity(ModelBuilder builder)
        {
            Trait trait = GetTrait();

            builder.AddTextBlocks(trait, GetDetailBlocks(), e => e.Details);
            builder.AddSourcePage(trait, GetSourcePage(), e => e.SourcePageId);
            
            return trait;
        }

        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract SourcePage GetSourcePage();
        protected abstract Trait GetTrait();
    }
}
