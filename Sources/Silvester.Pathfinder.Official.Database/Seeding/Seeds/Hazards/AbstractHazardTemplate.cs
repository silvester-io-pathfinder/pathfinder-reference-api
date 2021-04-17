using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards
{
    public abstract class AbstractHazardTemplate
    {
        public void Seed(HazardSeeder seeder)
        {
            Hazard hazard = GetHazard(seeder);

            SourcePage source = GetSourcePage(seeder);
            hazard.SourcePageId = source.Id;
            seeder.Builder.AddData(source);

            foreach (HazardRoutineDetailBlock routineDetail in GetRoutineDetails(seeder))
            {
                routineDetail.HazardId = hazard.Id;
                seeder.Builder.AddData(routineDetail);

                foreach (HazardComponent component in GetComponents(seeder))
                {
                    component.HazardId = hazard.Id;
                    seeder.Builder.AddData(component);
                }

                foreach (HazardAction action in GetActions(seeder))
                {
                    action.HazardId = hazard.Id;

                    foreach (HazardActionEffectBlock block in action.EffectDetails)
                    {
                        block.HazardActionId = action.Id;
                        seeder.Builder.AddData(block);
                    }
                    action.EffectDetails = new HazardActionEffectBlock[] { };

                    foreach (HazardActionEffect effect in action.Effects)
                    {
                        SeedHazardActionEffect(seeder, effect, action.Id);

                    }
                    action.Effects = new HazardActionEffect[] { };

                    foreach (Trait trait in action.Traits)
                    {
                        seeder.Builder.HasJoinData((action, trait));
                    }
                    action.Traits = new Trait[] { };

                    seeder.Builder.AddData(action);
                }

                foreach (HazardDisableRequirement requirement in GetDisableRequirements(seeder))
                {
                    requirement.HazardId = hazard.Id;
                    seeder.Builder.AddData(requirement);
                }

                foreach (HazardDispellRequirement requirement in GetDispellRequirements(seeder))
                {
                    requirement.HazardId = hazard.Id;
                    seeder.Builder.AddData(requirement);
                }

                foreach (HazardAction action in GetActions(seeder))
                {
                    action.HazardId = hazard.Id;
                    seeder.Builder.AddData(action);
                }

                seeder.Builder.AddData(hazard);

                foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
                {
                    seeder.Builder.HasJoinData((hazard, trait));
                }

                foreach (HazardImmunity immunity in seeder.FilterImmunities(GetImmunities().ToArray()))
                {
                    seeder.Builder.HasJoinData((hazard, immunity));
                }

            }
        }

        private void SeedHazardActionEffect(HazardSeeder seeder, HazardActionEffect effect, Guid actionId)
        {
            effect.HazardActionId = actionId;

            foreach (Trait trait in effect.Traits)
            {
                seeder.Builder.HasJoinData((trait, effect));
            }
            effect.Traits = new Trait[0];

            if (effect is PoisonHazardActionEffect poisonHazardActionEffect)
            {
                foreach (StaggeredEffectStage stage in poisonHazardActionEffect.PoisonEffect.Stages)
                {
                    stage.StaggeredEffectId = poisonHazardActionEffect.PoisonEffect.Id;

                    foreach (StaggeredEffectStageEffect stageEffect in stage.Effects)
                    {
                        stageEffect.StaggeredEffectStageId = stage.Id;
                        seeder.Builder.AddData(stage);
                    }
                    stage.Effects = new StaggeredEffectStageEffect[] { };

                    seeder.Builder.AddData(stage);
                }
                poisonHazardActionEffect.PoisonEffect.Stages = new StaggeredEffectStage[] { };

                seeder.Builder.AddData(poisonHazardActionEffect.PoisonEffect);
            }

            seeder.Builder.AddData(effect.GetType(), effect);
        }

        protected abstract Hazard GetHazard(HazardSeeder seeder);
        protected abstract SourcePage GetSourcePage(HazardSeeder seeder);
        protected abstract HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder);
        protected abstract IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder);

        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<string> GetImmunities();
        protected abstract IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder);
        protected abstract IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder);
        protected abstract IEnumerable<HazardAction> GetActions(HazardSeeder seeder);

        protected virtual IEnumerable<HazardRoutineDetailBlock> GetRoutineDetails(HazardSeeder seeder)
        {
            yield break;
        }
    }
}
