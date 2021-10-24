using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Senses
{
    public abstract class Template : EntityTemplate<Sense>
    {
        protected override Sense GetEntity(ModelBuilder builder)
        {
            Sense sense = GetSense();

            builder.AddSourcePage(sense, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(sense, GetDetailBlocks(), (c) => c.Details);

            return sense;
        }

        public abstract Sense GetSense();
        public abstract SourcePage GetSourcePage();
        public abstract IEnumerable<TextBlock> GetDetailBlocks();
    }
}
