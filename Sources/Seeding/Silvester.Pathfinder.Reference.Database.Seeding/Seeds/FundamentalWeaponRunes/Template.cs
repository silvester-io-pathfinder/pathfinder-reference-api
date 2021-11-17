using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.FundamentalWeaponRunes
{
    public abstract class Template : EntityTemplate<FundamentalWeaponRune>
    {
        protected override FundamentalWeaponRune GetEntity(ISeedBuilder builder)
        {
            FundamentalWeaponRune rune = GetRune();

            builder.AddSourcePage(rune, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(rune, GetTraits());
            builder.AddTextBlocks(rune, GetDetails(), e => e.Details);

            foreach(FundamentalWeaponRuneVariant level in GetLevels())
            {
                level.RuneId = rune.Id;
                builder.AddData(level);
            }

            return rune;
        }

        protected abstract IEnumerable<FundamentalWeaponRuneVariant> GetLevels();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract SourcePage GetSourcePage();
        protected abstract FundamentalWeaponRune GetRune();
    }
}
