using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class ArmageddonOrb : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("e825d010-508c-4618-b2c1-7c8e54a14d96");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Armageddon Orb",
                Description = "A roiling red orb, forged from a drop of the god Rovagug’s blood, rains fire from the sky when a specified condition is met.",
                Level = 23,
                CanBeDetectedMagically = true,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
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
            yield return "Rare";
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("ea62e9d7-f1ba-4f23-abb7-0f76ec9dbaeb"),
                Name = "Burn it All",
                Traits = seeder.FilterTraits("Death", "Divine", "Evocation", "Fire"),
                Trigger = "special condition set by the trap’s creator occurs; this is typically the event of their death;",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("bbf0858b-6ab3-4a6e-90f3-8e4ca74206a8"),Type = TextBlockType.Text,  Text = "Fire rains from the sky in a 100-mile radius, dealing 10d6 fire damage to creatures and objects in the area. Each creature or object can attempt a DC 46 basic Reflex save. Any creature reduced to 0 Hit Points by this damage dies instantly. This is not enough damage to completely burn away a forest or level an entire mountain or city, but it typically kills most creatures in the area." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("bb69f5a8-1208-4b58-9923-dd4fbd3309b5"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Untrained").Id,
                DifficultyCheck = 10
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("0e1b3b3d-aa2d-4963-8bb4-3485e14be099"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Legendary").Id,
                Description = "to imbue thieves’ tools with aspects representing Asmodeus and Sarenrae and use them to drain away the orb’s power over 10 minutes; the character attempting this check takes 5 fire damage each round until the orb is depleted",
                DifficultyCheck = 48
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
                Id = Guid.Parse("0e1b3b3d-aa2d-4963-8bb4-3485e14be099"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 526
            };
        }
    }
}
