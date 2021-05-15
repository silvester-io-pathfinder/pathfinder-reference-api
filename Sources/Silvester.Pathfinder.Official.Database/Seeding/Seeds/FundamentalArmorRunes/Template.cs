using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalArmorRunes
{
    public abstract class Template : EntityTemplate<FundamentalArmorRune>
    {
        protected override FundamentalArmorRune GetEntity(ModelBuilder builder)
        {
            FundamentalArmorRune rune = GetRune();

            SourcePage sourcePage = GetSourcePage();
            rune.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            builder.AddTextBlocks(rune, GetDetails(), e => e.Details);

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<FundamentalArmorRune, Trait>((rune.Id, traitId));
            }

            foreach(FundamentalArmorRuneVariant level in GetLevels())
            {
                level.RuneId = rune.Id;
                builder.AddData(level);
            }

            return rune;
        }

        protected abstract IEnumerable<FundamentalArmorRuneVariant> GetLevels();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract FundamentalArmorRune GetRune();
    }
}
