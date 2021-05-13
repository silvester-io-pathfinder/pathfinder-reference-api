using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits
{
    public abstract class Template : EntityTemplate<Trait>
    {
        protected override Trait GetEntity(ModelBuilder builder)
        {
            Trait trait = GetTrait();

            builder.AddTextBlocks(trait, GetDetailBlocks(), e => e.Details);

            SourcePage sourcePage = GetSourcePage();
            if (sourcePage != null)
            {
                builder.AddData(sourcePage);
                trait.SourcePageId = sourcePage.Id;
            }

            return trait;
        }

        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract SourcePage GetSourcePage();
        protected abstract Trait GetTrait();
    }
}
