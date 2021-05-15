using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.FundamentalArmorPropertyRunes
{
    public abstract class Template : EntityTemplate<FundamentalArmorPropertyRune>
    {
        protected override FundamentalArmorPropertyRune GetEntity(ModelBuilder builder)
        {
            FundamentalArmorPropertyRune rune = GetRune();

            SourcePage sourcePage = GetSourcePage();
            rune.SourcePageId = sourcePage.Id;
            builder.AddData(sourcePage);

            builder.AddTextBlocks(rune, GetDetails(), e => e.Details);

            foreach(Guid traitId in GetTraits())
            {
                builder.HasJoinData<FundamentalArmorPropertyRune, Trait>((rune.Id, traitId));
            }

            foreach(FundamentalArmorPropertyRuneVariant level in GetLevels())
            {
                level.RuneId = rune.Id;
                builder.AddData(level);
            }

            return rune;
        }

        protected abstract IEnumerable<FundamentalArmorPropertyRuneVariant> GetLevels();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract FundamentalArmorPropertyRune GetRune();
    }
}
