using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats
{
    public abstract class Template : EntityTemplate<Feat>
    {
        protected override Feat GetEntity(ISeedBuilder builder)
        {
            Feat feat = GetFeat();

            builder.AddRollableEffect(feat, GetRollableEffect());
            builder.AddTraitBindings<FeatTraitBinding, Feat>(feat, GetTraits);
            builder.AddTextBlocks(feat, GetDetailBlocks(), e => e.Details);
            builder.AddEffect(feat, GetCharacterEffects, e => e.EffectId);
            builder.AddPrerequisite(feat, (builder) => GetPrerequisites(feat, builder));
            builder.AddSourcePage(feat, GetSourcePage(), e => e.SourcePageId);

            return feat;
        }

        protected abstract Feat GetFeat();
        protected abstract void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder);
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract SourcePage GetSourcePage();

        protected virtual void GetCharacterEffects(BooleanEffectBuilder builder)
        {
            //Override in concrete subclass to add feat effects to the character that picks them.
        }

        private void GetPrerequisites(Feat feat, BooleanPrerequisiteBuilder builder)
        {
            builder.HaveSpecificLevel(feat.Id.Increment(1), Comparator.GreaterThanOrEqualTo, requiredLevel: feat.Level);
            GetPrerequisites(builder);
        }

        protected virtual void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {

        }

        protected virtual RollableEffect? GetRollableEffect()
        {
            return null;
        }
    }
}