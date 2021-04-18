using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class Quicksand : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("8bb8a7b1-c597-480b-8a23-5d28157c0310");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Quicksand",
                Description = "A 15-foot-wide patch of water and sand attempts to submerge creatures that step onto it.",
                Level = 3,
                Reset = "The hazard still submerges anyone who walks in, but the surface doesn’t become hidden again until it settles over the course of 24 hours",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Environmental Hazards").Id,
                ComplexityId = seeder.GetComplexityByName("Complex").Id,
                RoutineActions = 1
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield break;
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Complex";
            yield return "Environmental";
        }

        protected override IEnumerable<HazardRoutineDetailBlock> GetRoutineDetails(HazardSeeder seeder)
        {
            yield return new HazardRoutineDetailBlock { Id = Guid.Parse("f5149d1e-92e7-468d-aaf7-c71f195e464a"), Type = HazardRoutineDetailBlockType.Text, Text = "On its initiative, the quicksand pulls down each creature within it. A creature that was submerged up to its waist becomes submerged up to its neck, and a creature that was submerged up to its neck is pulled under and has to hold its breath to avoid suffocation(page 478)." };
            yield return new HazardRoutineDetailBlock { Id = Guid.Parse("4f8f2529-93b8-4bad-8841-59f73d6e119c"), Type = HazardRoutineDetailBlockType.Text, Text = "A creature in the quicksand can attempt a DC 20 Athletics check to Swim to either raise itself by one step if it’s submerged to its neck or worse, or to move 5 feet if it’s submerged only up to its waist. On a critical failure, the creature is pulled down one step. A creature that Swims out of the quicksand escapes the hazard and is prone in a space adjacent to the quicksand patch. Other creatures can Aid the creature, typically by using a rope or similar aid, or attempt to pull the creature out with their own DC 20 Athletics check, with the same results as if the creature attempted the check." };
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("d1adf885-1c78-4d30-b759-12798dc37a4a"),
                Name = "Submerge",
                Trigger = "A Huge or smaller creature walks onto the quicksand",
                ActionTypeId = seeder.GetActionTypeByName("Free").Id,
                EffectDetails =
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("a9f37fc2-82d6-466c-adc8-552f4b20da56"), Text = "The triggering creature sinks into the quicksand up to its waist. The quicksand rolls initiative if it hasn’t already." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("2fd88f3c-f040-455b-bb12-78dad3d5e6bc"),
                Addendum = "If the surface is disturbed, the DC drops to 2 and has no minimum required proficiency.",
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 12
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("5af71fdd-656c-4eaa-9c12-e63925f32a0d"),
                SkillId = seeder.GetSkillByName("Survival").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                Description = "to disturb the surface",
                DifficultyCheck = 18
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield break;
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("5285ad8d-011b-4404-861a-6c266475600f"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 526
            };
        }
    }
}
