using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HiddenPit : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Hidden Pit",
                Description = "A wooden trapdoor covers a pit that’s 10 feet square and 20 feet deep.",
                Level = 0,
                ArmorClass = 10,
                Fortitude = 1,
                Reflex = 1,
                HitPoints = 12,
                Hardness = 3,
                BrokenThreshold = 6,
                Reset = "Creatures can still fall into the trap, but the trapdoor must be reset manually for the trap to become hidden again.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield return "Critical Hits";
            yield return "Object Immunities";
            yield return "Precision Damage";
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Mechanical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse(""),
                Name = "Pitfall",
                Effect = "The triggering creature falls in and takes falling damage (typically 10 bludgeoning damage). That creature can use the Grab an Edge reaction to avoid falling.",
                Trigger = "A creature walks onto the trapdoor",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse(""),
                Addendum = "If the trapdoor is disabled or broken, the Difficulty Check becomes 0.",
                RequiredProficiencyId = seeder.GetProficiencyByName("Untrained").Id,
                DifficultyCheck = 18
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse(""),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Untrained").Id,
                Description = "to remove the trapdoor",
                DifficultyCheck = 12
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield break;
        }
    }
}
