using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes
{
    public abstract class Template : EntityTemplate<Archetype>
    {
        protected override Archetype GetEntity(ISeedBuilder builder)
        {
            Archetype archetype = GetArchetype();
            
            builder.AddTextBlocks(archetype, GetDetails(), (e) => e.Details);
            builder.AddTextBlocks(archetype, GetMulticlassDetails(), (e) => e.MulticlassDetails);
            builder.AddSourcePage(archetype, GetSourcePage(), (e) => e.SourcePageId);

            return archetype;
        }

        protected abstract Archetype GetArchetype();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();

        protected virtual IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield break;
        }
    }
}
