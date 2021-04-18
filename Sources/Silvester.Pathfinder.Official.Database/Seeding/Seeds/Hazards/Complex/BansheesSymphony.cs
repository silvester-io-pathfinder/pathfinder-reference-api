using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Complex
{
    public class BansheesSymphony : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("ff781a33-7aa2-426b-adf2-672bcf0e1681");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Banshee's Symphony",
                Description = "A magically contagious wail of the banshee spell is trapped in the larynx of an invisible, mummified elf.",
                Level = 18,
                Reset = "The trap ends when the trap is unable to make a creature scream (usually because no creature failed its save on the previous turn or because all creatures have critically succeeded in the past). It then resets over 24 hours, as a new scream builds up in the mummified larynx.",
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
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
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails(HazardSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("2411b443-2b72-48d1-b59e-b6688b774df9"), Type = TextBlockType.Text, Text = "The trap uses its action to force one random creature that failed its save against wail of the banshee last turn to emit a wail of the banshee with the same statistics as the initial one. The creature wails even if it is dead or unable to speak, no matter how far away from the trap it is. Unlike a casting of the spell, the drained condition from this trap’s wail of the banshee spells increases the targets’ drained condition values. A creature that critically succeeds at any of its saves can still be affected by the trap on future rounds, but can’t be forced to wail by the trap." };
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("d403f5f2-59b1-446b-b31c-a91b8337c776"),
                Name = "Scream",
                Trigger = "Three or more living creatures remain within 100 feet of the trap for 6 seconds or longer",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("73e328d7-b078-4c03-a8ac-2f8f2191835e"), Type = Utilities.Text.TextBlockType.Text, Text = "The trap releases an arcane wail of the banshee (DC 40) with a 100-foot-radius emanation instead of 40 feet, targeting all living creatures in the area, and rolls initiative." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9f5a71e8-3044-4216-9aaa-846f17d46be1"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Legendary").Id,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("d3d70679-6b55-4f37-9fc9-b1d7059535f5"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                Description = "to pierce the invisible larynx so precisely that the magic releases in a trickle before the trap activates",
                DifficultyCheck = 42
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f422309b-4d6f-42c6-820f-3870ac4d7891"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Legendary").Id,
                Description = "three times to deconstruct the larynx while the trap is active in such a way that it tears the spell apart",
                DifficultyCheck = 44
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("0f0eee9b-3bb9-44b8-8674-8913633f6ba5"),
                Level = 9,
                Description = "to counteract the wail of the banshee before the trap activates",
                CounteractDifficultyCheck = 38
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("dae57ffc-a1ec-4a36-87fb-6188e72dbd2a"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 529
            };
        }
    }
}
