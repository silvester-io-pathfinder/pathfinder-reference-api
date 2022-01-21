using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Philosophies
{
    public abstract class Template : EntityTemplate<Philosophy>
    {
        protected override Philosophy GetEntity(ISeedBuilder builder)
        {
            Philosophy philosophy = GetPhilosophy();

            builder.AddTextBlocks(philosophy, GetDetails(), (e) => e.Details);
            builder.AddSourcePage(philosophy, GetSourcePage(), (e => e.SourcePageId));

            return philosophy;
        }

        protected abstract Philosophy GetPhilosophy();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetRequiredAlignments();
    }
}
