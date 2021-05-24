using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Shields
{
    public abstract class Template : EntityTemplate<Shield>
    {
        protected override Shield GetEntity(ModelBuilder builder)
        {
            Shield shield = GetShield();

            builder.AddSourcePage(shield, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(shield, GetDetails(), e => e.Details);

            return shield;
        }

        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract Shield GetShield();
    }
}
