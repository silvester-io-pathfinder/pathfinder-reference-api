using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards
{
    public abstract class Template : EntityTemplate<Hazard>
    {
        protected override Hazard GetEntity(ModelBuilder builder)
        {
            Hazard hazard = GetHazard();

            builder.AddSourcePage(hazard, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(hazard, GetTraits());
            builder.AddTextBlocks(hazard, GetRoutineDetails(), e => e.RoutineDetails);
            builder.HasJoinData<Hazard, Immunity>(hazard, GetImmunities());

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
                builder.AddStaggeredEffect(poisonHazardActionEffect, poisonHazardActionEffect.PoisonEffect, e => e.PoisonEffectId);
                poisonHazardActionEffect.PoisonEffect = null!;
            }

            builder.AddData(effect.GetType(), effect);
        }

        protected static Trait[] FilterTraits(params string [] names)
        {
            return new EntityTemplateProvider<Trait>()
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