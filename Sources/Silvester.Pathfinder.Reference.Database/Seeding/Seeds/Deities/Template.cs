using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities
{
    public abstract class Template : EntityTemplate<Deity>
    {
        protected override Deity GetEntity(ModelBuilder builder)
        {
            Deity deity = GetDeity();

            builder.AddTextBlocks(deity, GetDetails(), e => e.Details);
            builder.AddSourcePage(deity, GetSourcePage(), e => e.SourcePageId);
            builder.HasJoinData<Deity, Alignment>(deity, GetFollowerAlignments());
            builder.HasJoinData<Deity, DivineFont>(deity, GetDivineFonts());
            builder.HasJoinData<Deity, Domain>(deity, GetDomains());
            builder.HasJoinData<Deity, Skill>(deity, GetDivineSkills());
            builder.HasJoinData<Deity, Stat>(deity, GetDivineStats());
            builder.HasJoinData<Deity, MeleeWeapon>(deity, GetFavoredMeleeWeapons());
            builder.HasJoinData<Deity, RangedWeapon>(deity, GetFavoredRangedWeapons());
            builder.HasJoinData<Deity, UnarmedWeapon>(deity, GetFavoredUnarmedWeapons());
            builder.AddEffect(deity, GetDevoteeEffect);

            DivineIntercession? intercession = GetDivineIntercession();
            if(intercession != null)
            {
                deity.DivineIntercessionId = intercession.Id;

                builder.AddSourcePage(intercession, intercession.SourcePage, e => e.SourcePageId);
                intercession.SourcePage = null!;

                builder.AddData(intercession);
            }

            return deity;
        }

        protected abstract Deity GetDeity();
        protected abstract SourcePage GetSourcePage();
        protected abstract DivineIntercession? GetDivineIntercession();
        protected abstract IEnumerable<TextBlock> GetDetails();
        protected abstract IEnumerable<Guid> GetFollowerAlignments();
        protected abstract IEnumerable<Guid> GetDivineFonts();
        protected abstract IEnumerable<Guid> GetDivineSkills();
        protected abstract IEnumerable<Guid> GetDivineStats();
        protected abstract IEnumerable<Guid> GetDomains();
        protected abstract IEnumerable<Guid> GetFavoredMeleeWeapons();
        protected abstract IEnumerable<Guid> GetFavoredRangedWeapons();
        protected abstract IEnumerable<Guid> GetFavoredUnarmedWeapons();
        protected abstract void GetDevoteeEffect(BooleanEffectBuilder builder);
    }
}
