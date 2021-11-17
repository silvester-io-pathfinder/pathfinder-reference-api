using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Eidolons
{
    public abstract class Template : EntityTemplate<Eidolon>
    {
        protected override Eidolon GetEntity(ISeedBuilder builder)
        {
            Eidolon eidolon = GetEidolon();

            builder.AddSourcePage(eidolon, GetSourcePage(), (e => e.SourcePageId));
            builder.AddEffect(eidolon, GetEffects, e => e.EffectId);

            builder.AddJoinData<Eidolon, Trait>(eidolon, GetTraits());
            builder.AddJoinData<Eidolon, Alignment>(eidolon, GetRequiredAlignments());
            builder.AddJoinData<Eidolon, Skill>(eidolon, GetSkills());
            builder.AddJoinData<Eidolon, Sense>(eidolon, GetSenses());
            builder.AddJoinData<Eidolon, AncestrySize>(eidolon, GetSizes());
            foreach (EidolonAbility ability in GetAbilities())
            {
                SeedAbility(builder, eidolon, ability);
            }

            foreach (EidolonVariant variant in GetVariants())
            {
                SeedVariant(builder, eidolon, variant);
            }

            foreach (EidolonHomePlane plane in GetHomePlanes())
            {
                SeedPlane(builder, eidolon, plane);
            }

            return eidolon;
        }

        private void SeedAbility(ISeedBuilder builder, Eidolon eidolon, EidolonAbility ability)
        {
            ability.EidolonId = eidolon.Id;

            builder.AddTextBlocks(ability, ability.Details, (e) => e.Details);
            ability.Details = new List<TextBlock>();

            builder.AddEffect(ability.Effect);
            ability.Effect = null;

            builder.AddData(ability);
        }

        private void SeedVariant(ISeedBuilder builder, Eidolon eidolon, EidolonVariant variant)
        {
            variant.EidolonId = eidolon.Id;
            builder.AddData(variant);
        }

        private void SeedPlane(ISeedBuilder builder, Eidolon eidolon, EidolonHomePlane plane)
        {
            plane.EidolonId = eidolon.Id;

            builder.AddPrerequisite(plane.Prerequisite);
            plane.Prerequisite = null;

            builder.AddData(plane);
        }

        protected abstract Eidolon GetEidolon();
        protected abstract SourcePage GetSourcePage();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetRequiredAlignments();
        protected abstract IEnumerable<Guid> GetSkills();
        protected abstract IEnumerable<Guid> GetSenses();
        protected abstract IEnumerable<Guid> GetSizes();
        protected abstract IEnumerable<EidolonVariant> GetVariants();
        protected abstract IEnumerable<EidolonAbility> GetAbilities();
        protected abstract IEnumerable<EidolonHomePlane> GetHomePlanes();
    }
}
