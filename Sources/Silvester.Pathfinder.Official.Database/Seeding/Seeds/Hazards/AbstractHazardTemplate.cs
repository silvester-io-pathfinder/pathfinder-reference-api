using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards
{
    public abstract class AbstractHazardTemplate : EntityTemplate<Hazard>
    {
        protected override Hazard GetEntity(ModelBuilder builder)
        {
            Hazard hazard = GetHazard();

            SourcePage source = GetSourcePage();
            hazard.SourcePageId = source.Id;
            builder.AddData(source);

            builder.AddTextBlocks(hazard, GetRoutineDetails(), e => e.RoutineDetails);
            
            foreach (HazardComponent component in GetComponents())
            {
                component.HazardId = hazard.Id;
                builder.AddData(component);
            }

            foreach (HazardAction action in GetActions())
            {
                action.HazardId = hazard.Id;

                builder.AddTextBlocks(action, action.Details, e => e.Details);
                action.Details = Array.Empty<TextBlock>();

                foreach (HazardActionEffect effect in action.Effects)
                {
                    SeedHazardActionEffect(builder, effect, action.Id);

                }
                action.Effects = Array.Empty<HazardActionEffect>();

                foreach (Trait trait in action.Traits)
                {
                    builder.HasJoinData((action, trait));
                }
                action.Traits = Array.Empty<Trait>();

                builder.AddData(action);
            }

            foreach (HazardDisableRequirement requirement in GetDisableRequirements())
            {
                requirement.HazardId = hazard.Id;
                builder.AddData(requirement);
            }

            foreach (HazardDispellRequirement requirement in GetDispellRequirements())
            {
                requirement.HazardId = hazard.Id;
                builder.AddData(requirement);
            }

            foreach (Guid traitId in GetTraits())
            {
                builder.HasJoinData<Trait, Hazard>((traitId, hazard.Id));
            }

            foreach (Guid immunityId in GetImmunities())
            {
                builder.HasJoinData<HazardImmunity, Hazard>((immunityId, hazard.Id));
            }

            return hazard;
        }

        private static void SeedHazardActionEffect(ModelBuilder builder, HazardActionEffect effect, Guid actionId)
        {
            effect.HazardActionId = actionId;

            foreach (Trait trait in effect.Traits)
            {
                builder.HasJoinData((trait, effect));
            }
            effect.Traits = Array.Empty<Trait>();

            if (effect is PoisonHazardActionEffect poisonHazardActionEffect)
            {
                poisonHazardActionEffect.PoisonEffectId = poisonHazardActionEffect.PoisonEffect.Id;
                foreach (StaggeredEffectStage stage in poisonHazardActionEffect.PoisonEffect.Stages)
                {
                    foreach (StaggeredEffectStageEffect stageEffect in stage.Effects)
                    {
                        stageEffect.StaggeredEffectStageId = stage.Id;
                        builder.AddData(stageEffect.GetType(), stageEffect);
                    }
                    stage.Effects = Array.Empty<StaggeredEffectStageEffect>();

                    stage.StaggeredEffectId = poisonHazardActionEffect.PoisonEffectId;
                    builder.AddData(stage);
                }
                poisonHazardActionEffect.PoisonEffect.Stages = Array.Empty<StaggeredEffectStage>();
                builder.AddData(poisonHazardActionEffect.PoisonEffect);

                poisonHazardActionEffect.PoisonEffect = null!;
            }

            builder.AddData(effect.GetType(), effect);
        }

        protected static Trait[] FilterTraits(params string [] names)
        {
            return new TemplateProvider<Trait>()
                .GetTemplates()
                .Select(e => (Trait) e.GetType().GetMethod("GetTrait", BindingFlags.NonPublic | BindingFlags.Instance)!.Invoke(e, null)!)
                .Where(e => names.Contains(e.Name))
                .ToArray();
        }

        protected abstract Hazard GetHazard();
        protected abstract SourcePage GetSourcePage();
        protected abstract HazardDetectionRequirement GetDetectionRequirement();
        protected abstract IEnumerable<HazardComponent> GetComponents();

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetImmunities();
        protected abstract IEnumerable<HazardDisableRequirement> GetDisableRequirements();
        protected abstract IEnumerable<HazardDispellRequirement> GetDispellRequirements();
        protected abstract IEnumerable<HazardAction> GetActions();

        protected virtual IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield break;
        }
    }
}