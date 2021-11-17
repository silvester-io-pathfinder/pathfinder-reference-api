using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries
{
    public abstract class Template : EntityTemplate<Ancestry>
    {
        protected override Ancestry GetEntity(ISeedBuilder builder)
        {
            Ancestry ancestry = GetAncestry();

            builder.AddEffect(ancestry, GetEffects, e => e.EffectId);
            builder.AddSourcePage(ancestry, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(ancestry, GetTraits());
            builder.AddTextBlocks(ancestry, GetDescription(), e => e.Description);
            builder.AddTextBlocks(ancestry, GetYouMight(), e => e.YouMight);
            builder.AddTextBlocks(ancestry, GetOthersProbably(), e => e.OthersProbably);
            builder.AddTextBlocks(ancestry, GetPhysicalDescription(), e => e.PhysicalDescription);
            builder.AddTextBlocks(ancestry, GetSociety(), e => e.Society);
            builder.AddTextBlocks(ancestry, GetAlignmentAndReligion(), e => e.AlignmentAndReligion);
            builder.AddTextBlocks(ancestry, GetAdventurers(), e => e.Adventurers);
            builder.AddTextBlocks(ancestry, GetNames(), e => e.Names);
            builder.AddTextBlocks(ancestry, GetOtherInformation(), e => e.OtherInformation);
            builder.AddTextBlocks(ancestry, GetAdditionalMechanics(), e => e.AdditionalMechanics);
            builder.AddJoinData<Ancestry, AncestrySize>(ancestry, GetSizes());

            return ancestry;
        }

        protected abstract void GetEffects(BooleanEffectBuilder builder);
        protected abstract Ancestry GetAncestry();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDescription();
        protected abstract IEnumerable<TextBlock> GetYouMight();
        protected abstract IEnumerable<TextBlock> GetOthersProbably();
        protected abstract IEnumerable<TextBlock> GetPhysicalDescription();
        protected abstract IEnumerable<TextBlock> GetSociety();
        protected abstract IEnumerable<TextBlock> GetAlignmentAndReligion();
        protected abstract IEnumerable<TextBlock> GetAdventurers();
        protected abstract IEnumerable<TextBlock> GetNames();
        protected abstract IEnumerable<TextBlock> GetAdditionalMechanics();
        protected abstract IEnumerable<Guid> GetSizes();

        protected virtual IEnumerable<TextBlock> GetOtherInformation()
        {
            yield break;
        }
    }
}
