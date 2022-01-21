using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineAttacks;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards
{
    public abstract class Template : EntityTemplate<Hazard>
    {
        protected override Hazard GetEntity(ISeedBuilder builder)
        {
            Hazard hazard = GetHazard();

            builder.AddSourcePage(hazard, GetSourcePage(), e => e.SourcePageId);
            builder.AddTraits(hazard, GetTraits());
            builder.AddTextBlocks(hazard, GetRoutineDetails(), e => e.RoutineDetails);
            builder.AddJoinData<Hazard, Immunity>(hazard, GetImmunities());
            builder.AddInlineActions(hazard, GetActions);
            builder.AddInlineAttacks(hazard, GetAttacks);

            foreach (HazardComponent component in GetComponents())
            {
                component.HazardId = hazard.Id;
                builder.AddData(component);
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

        protected abstract Hazard GetHazard();
        protected abstract SourcePage GetSourcePage();
        protected abstract HazardDetectionRequirement GetDetectionRequirement();
        protected abstract IEnumerable<HazardComponent> GetComponents();

        protected abstract IEnumerable<Guid> GetTraits();
        protected abstract IEnumerable<Guid> GetImmunities();
        protected abstract IEnumerable<HazardDisableRequirement> GetDisableRequirements();
        protected abstract IEnumerable<HazardDispellRequirement> GetDispellRequirements();
        protected abstract void GetActions(InlineActionCollectionBuilder builder);
        
        protected virtual void GetAttacks(InlineAttackCollectionBuilder builder)
        {

        }

        protected virtual IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield break;
        }
    }
}