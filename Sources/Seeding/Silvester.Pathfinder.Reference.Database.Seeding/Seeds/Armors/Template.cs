using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Armors
{
    public abstract class Template : EntityTemplate<Armor>
    {
        protected override Armor GetEntity(ISeedBuilder builder)
        {
            Armor armor = GetArmor();

            builder.AddSourcePage(armor, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(armor, GetTraits());
            builder.AddTextBlocks(armor, GetDetails(), e => e.Details);

            return armor;
        }

        protected abstract Armor GetArmor();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetTraits();
    }
}
