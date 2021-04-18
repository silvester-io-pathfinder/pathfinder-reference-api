using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class DarksideMirror : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("e3110eda-b8bf-4599-bfe6-d95ebaf43948");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Darkside Mirror",
                Description = "A magic mirror replaces characters with evil mirror duplicates from another dimension.",
                Level = 14,
                ArmorClass = 34,
                Fortitude = 25,
                Reflex = 20,
                Reset = "The mirror is always ready to absorb creatures into the other dimension. Ten minutes after a creature is sucked into the mirror, if an ally doesn’t rescue the creature with Thievery, it reaches the other dimension, where it might be captured or killed. In the mirror dimension, it counts as a mirror duplicate, so the denizens of the other dimension can’t destroy the mirror on their side while the absorbed creature is there. These dimensions are alternate realities, not planes, so even spells like plane shift can’t reach them.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Complex").Id,
                RoutineActions = 1
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield return new HazardComponent
            {
                Id = Guid.Parse("5963a30c-164a-4956-ab02-93a2e503eca9"),
                Name = "Mirror",
                Hardness = 1,
                HitPoints = 4,
                BrokenThreshold = 2,
                Addendum = "The mirror cannot be damaged while any mirror duplicate is alive."
            };
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Complex";
            yield return "Magical";
            yield return "Mechanical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardRoutineDetailBlock> GetRoutineDetails(HazardSeeder seeder)
        {
            yield return new HazardRoutineDetailBlock { Id = Guid.Parse("087a9701-90ab-4e85-a64d-8bca7032c349"), Type = HazardRoutineDetailBlockType.Text, Text = "The mirror absorbs another reflected creature into the mirror and replaces it with a mirror duplicate. Mirror duplicates attack on their own initiative, using the same statistics as the original creature, but with an evil alignment (changing only abilities that shift with the alignment change). A mirror duplicate can spend 3 actions in contact with the mirror to return to its original dimension and release the creature it duplicated, but most mirror duplicates prefer not to." };
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("b1955fcd-433f-45dc-b9ea-d69baa5fd5d9"),
                Name = "Reflection of Evil",
                Traits = seeder.FilterTraits("Arcane", "Conjuration", "Teleportation"),
                Trigger = "A non-evil creature is reflected in the mirror",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                EffectDetails =
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("5c6305bf-8791-4678-b24c-ab95f62fa7ab"), Text = "The mirror absorbs the creature into the mirror, replacing it with an evil mirror duplicate (DC 34 Reflex to avoid being absorbed into the mirror), and rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("83c43aec-6541-48fa-9e98-265f3e6337a2"),
                Addendum = "to notice it isn't a regular mirror",
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("97fdd750-a90e-4fab-a673-7fb5afe93c8c"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Legendary").Id,
                Description = "to retrieve a creature from the other dimension within 10 minutes of the switch (possible only if their mirror duplicate is dead)",
                DifficultyCheck = 34
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("ddc04b96-97f9-46f5-98ed-011ddade1d22"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                Description = "to permanently disable the mirror once all mirror duplicates are dead.",
                DifficultyCheck = 39
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("bbf7d133-7704-4e11-b56a-0c5ce2bcaee6"),
                Level = 7,
                Description = "to counteract the mirror for 1 minute and prevent additional replacements during that time",
                CounteractDifficultyCheck = 32
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("6230e629-ec2b-40b4-ab4f-eb1bc6619473"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 528
            };
        }
    }
}
