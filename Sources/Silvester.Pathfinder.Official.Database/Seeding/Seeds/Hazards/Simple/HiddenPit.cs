using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class HiddenPit : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("6d810cbc-bf1f-4232-9517-cbb95e4b5a33");

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
                Reset = "Creatures can still fall into the trap, but the trapdoor must be reset manually for the trap to become hidden again.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("807c4594-4f71-4ce5-828f-232678a7b1f6"),
                Name = "Trapdoor",
                HitPoints = 12,
                Hardness = 3,
                BrokenThreshold = 6,
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
                Id = Guid.Parse("a2bfaa34-76eb-43d8-a990-32b7437d8304"),
                Name = "Pitfall",
                Trigger = "A creature walks onto the trapdoor",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("21077b3a-26c5-4556-b3e5-b48e4970f323"), Type = TextBlockType.Text, Text = "The triggering creature falls in and takes falling damage (typically 10 bludgeoning damage). That creature can use the Grab an Edge reaction to avoid falling." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("2a2bf76d-3387-4400-b569-ee512180a409"),
                Addendum = "If the trapdoor is disabled or broken, the Difficulty Check becomes 0.",
                RequiredProficiencyId = seeder.GetProficiencyByName("Untrained").Id,
                DifficultyCheck = 18
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("1e0d3792-40ea-4884-921c-58305f558677"),
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

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bcc0fe0-0f4c-4d25-99e3-32db6fdfe7d1"),
                SourceId = CoreRulebook.ID,
                Page = 522
            };
        }
    }
}
