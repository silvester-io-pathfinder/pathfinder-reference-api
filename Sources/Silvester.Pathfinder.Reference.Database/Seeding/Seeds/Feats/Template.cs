using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
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

                    or.Choices = Array.Empty<Prerequisite>();
                }

                builder.Entity(prerequisite.GetType()).HasData(prerequisite);
            }

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
