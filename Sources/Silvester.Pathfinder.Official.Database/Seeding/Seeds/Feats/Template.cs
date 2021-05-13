using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats
{
    public abstract class Template :EntityTemplate<Feat>
    {
        protected override Feat GetEntity(ModelBuilder builder)
        {
            Feat feat = GetFeat();

            RollableEffect? rollableEffect = GetRollableEffect();
            if (rollableEffect != null)
            {
                builder.AddData(rollableEffect);
                feat.RollableEffectId = rollableEffect.Id;
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Feat>((traitId, feat.Id));
            }

            foreach (Prerequisite prerequisite in GetPrerequisites())
            {
                Prerequisite.FeatPrerequisiteBinding binding = builder.AddData(new Prerequisite.FeatPrerequisiteBinding { Id = prerequisite.Id, FeatId = feat.Id});
                prerequisite.BindingId = binding.Id;

                if(prerequisite is OrPrerequisite or)
                {
                    foreach(Prerequisite innerPrerequisite in or.Choices)
                    {
                        Prerequisite.OrBinding innerBinding = builder.AddData(new Prerequisite.OrBinding { Id = innerPrerequisite.Id, PrerequisiteId = prerequisite.Id });
                        innerPrerequisite.BindingId = innerBinding.Id;

                        builder.Entity(innerPrerequisite.GetType()).HasData(innerPrerequisite);
                    }

                    or.Choices.Clear();
                }

                builder.Entity(prerequisite.GetType()).HasData(prerequisite);
            }

            foreach (FeatRequirement requirement in GetRequirements())
            {
                builder.AddData(requirement);
                requirement.FeatId = feat.Id;
            }

            foreach (FeatEffect featEffect in GetEffects())
            {
                FeatEffect.FeatEffectBinding binding = builder.AddData(new FeatEffect.FeatEffectBinding { Id = featEffect.Id, FeatId = feat.Id });
                featEffect.BindingId = binding.Id;

                if(featEffect is OrFeatEffect or)
                {
                    foreach(FeatEffect innerEffect in or.Choices)
                    {
                        FeatEffect.OrEffectBinding innerBinding = builder.AddData(new FeatEffect.OrEffectBinding { Id = innerEffect.Id, OrFeatEffectId = featEffect.Id });
                        innerEffect.BindingId = innerBinding.Id;

                        builder.Entity(innerEffect.GetType()).HasData(innerEffect);
                    }

                    or.Choices.Clear();
                }
              
                builder.Entity(featEffect.GetType()).HasData(featEffect);
            }

            builder.AddTextBlocks(feat, GetDetailBlocks(), e => e.Details);

            return feat;
        }

        protected abstract Feat GetFeat();
        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();

        protected virtual IEnumerable<FeatEffect> GetEffects()
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
