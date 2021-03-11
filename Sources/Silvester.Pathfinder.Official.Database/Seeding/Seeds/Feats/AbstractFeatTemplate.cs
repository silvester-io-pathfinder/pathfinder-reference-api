using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats
{
    public abstract class AbstractFeatTemplate
    {
        public void Seed(FeatSeeder seeder)
        {
            Feat feat = GetFeat();
            feat.ActionTypeId = seeder.FilterActionTypes(ActionType)[0].Id;
            feat.FeatTypeId = seeder.FilterFeatTypes(FeatType)[0].Id;

            RollableEffect? rollableEffect = GetRollableEffect();
            if (rollableEffect != null)
            {
                seeder.Builder.AddData(rollableEffect);
                feat.RollableEffectId = rollableEffect.Id;
            }

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((feat, trait));
            }

            foreach (Prerequisite prerequisite in GetPrerequisites(seeder))
            {
                Prerequisite.FeatPrerequisiteBinding binding = seeder.Builder.AddData(new Prerequisite.FeatPrerequisiteBinding { Id = prerequisite.Id, FeatId = feat.Id});
                prerequisite.BindingId = binding.Id;

                if(prerequisite is OrPrerequisite or)
                {
                    foreach(Prerequisite innerPrerequisite in or.Choices)
                    {
                        Prerequisite.OrBinding innerBinding = seeder.Builder.AddData(new Prerequisite.OrBinding { Id = innerPrerequisite.Id, PrerequisiteId = prerequisite.Id });
                        innerPrerequisite.BindingId = innerBinding.Id;

                        seeder.Builder.Entity(innerPrerequisite.GetType()).HasData(innerPrerequisite);
                    }

                    or.Choices.Clear();
                }

                seeder.Builder.Entity(prerequisite.GetType()).HasData(prerequisite);
            }

            foreach (FeatRequirement requirement in GetRequirements())
            {
                seeder.Builder.AddData(requirement);
                requirement.FeatId = feat.Id;
            }

            
            foreach (FeatEffect featEffect in GetEffects(seeder))
            {
                FeatEffect.FeatEffectBinding binding = seeder.Builder.AddData(new FeatEffect.FeatEffectBinding { Id = featEffect.Id, FeatId = feat.Id });
                featEffect.BindingId = binding.Id;

                if(featEffect is OrFeatEffect or)
                {
                    foreach(FeatEffect innerEffect in or.Choices)
                    {
                        FeatEffect.OrEffectBinding innerBinding = seeder.Builder.AddData(new FeatEffect.OrEffectBinding { Id = innerEffect.Id, OrFeatEffectId = featEffect.Id });
                        innerEffect.BindingId = innerBinding.Id;

                        seeder.Builder.Entity(innerEffect.GetType()).HasData(innerEffect);
                    }

                    or.Choices.Clear();
                }
              
                seeder.Builder.Entity(featEffect.GetType()).HasData(featEffect);
            }

            foreach(FeatDetailsBlock block in GetDetailBlocks())
            {
                block.FeatId = feat.Id;
                seeder.Builder.AddData(block);
            }

            seeder.Builder.AddData(feat);
        }

        protected abstract Feat GetFeat();
        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<FeatDetailsBlock> GetDetailBlocks();
        protected abstract string FeatType { get; }
        protected abstract string ActionType { get; }

        protected virtual IEnumerable<FeatEffect> GetEffects(FeatSeeder seeder)
        {
            //Override in concrete subclass to add feat effects.
            yield break;
        }

        protected virtual IEnumerable<Prerequisite> GetPrerequisites(FeatSeeder seeder)
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
