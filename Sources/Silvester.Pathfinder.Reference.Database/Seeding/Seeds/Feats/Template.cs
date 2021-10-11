using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats
{
    public abstract class Template : EntityTemplate<Feat>
    {
        protected override Feat GetEntity(ModelBuilder builder)
        {
            Feat feat = GetFeat();

            builder.AddRollableEffect(feat, GetRollableEffect(), e => e.RollableEffect);
            builder.AddTraits(feat, GetTraits());
            builder.AddTextBlocks(feat, GetDetailBlocks(), e => e.Details);
            builder.AddEffects(GetEffects(), (effect) => new FeatEffectBinding { FeatId = feat.Id });
            builder.AddPrerequisites(GetPrerequisites(), () => new FeatPrerequisiteBinding { FeatId = feat.Id });
            builder.AddSourcePage(feat, GetSourcePage(), e => e.SourcePageId);
            

            foreach (FeatRequirement requirement in GetRequirements())
            {
                builder.AddData(requirement);
                requirement.FeatId = feat.Id;
            }

            return feat;
        }

        protected abstract Feat GetFeat();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract SourcePage GetSourcePage();

        protected virtual IEnumerable<Effect> GetEffects()
        {
            //Override in concrete subclass to add feat effects.
            yield break;
        }

        protected virtual IEnumerable<Prerequisite> GetPrerequisites()
        {
            //Override in concrete subclass to add prerequisites.
            yield break;
        }

        protected virtual IEnumerable<FeatRequirement> GetRequirements()
        {
            //Override in concrete subclass to add requirement prerequisites.
            yield break;
        }

        protected virtual RollableEffect? GetRollableEffect()
        {
            return null;
        }
    }
}
