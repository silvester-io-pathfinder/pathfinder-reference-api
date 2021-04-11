using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards
{
    public abstract class AbstractHazardTemplate
    {
        public void Seed(HazardSeeder seeder)
        {
            Hazard hazard = GetHazard(seeder);

            foreach (Trait trait in seeder.FilterTraits(GetTraits().ToArray()))
            {
                seeder.Builder.HasJoinData((hazard, trait));
            }

            foreach (HazardImmunity immunity in seeder.FilterImmunities(GetImmunities().ToArray()))
            {
                seeder.Builder.HasJoinData((hazard, immunity));
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

            SeedReaction(seeder, hazard);

            seeder.Builder.AddData(hazard);
        }

        private void SeedReaction(HazardSeeder seeder, Hazard hazard)
        {
            HazardReaction reaction = GetReaction(seeder);
            reaction.Id = hazard.Id.Increment();

            seeder.Builder.AddData(reaction);
        }

        protected abstract Hazard GetHazard(HazardSeeder seeder);
        protected abstract HazardReaction GetReaction(HazardSeeder seeder);
        protected abstract HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder);

        protected abstract IEnumerable<string> GetTraits();
        protected abstract IEnumerable<string> GetImmunities();
        protected abstract IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder);
        protected abstract IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder);
    }
}
