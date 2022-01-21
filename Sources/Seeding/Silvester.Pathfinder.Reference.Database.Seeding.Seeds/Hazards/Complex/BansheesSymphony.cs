using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Hazards.Complex
{
    public class BansheesSymphony : Template
    {
        public static readonly Guid ID = Guid.Parse("ff781a33-7aa2-426b-adf2-672bcf0e1681");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Banshee's Symphony",
                Description = "A magically contagious wail of the banshee spell is trapped in the larynx of an invisible, mummified elf.",
                Level = 18,
                Reset = "The trap ends when the trap is unable to make a creature scream (usually because no creature failed its save on the previous turn or because all creatures have critically succeeded in the past). It then resets over 24 hours, as a new scream builds up in the mummified larynx.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Complex.ID,
                RoutineActions = 1
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Complex.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<TextBlock> GetRoutineDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2411b443-2b72-48d1-b59e-b6688b774df9"), Type = TextBlockType.Text, Text = "The trap uses its action to force one random creature that failed its save against wail of the banshee last turn to emit a wail of the banshee with the same statistics as the initial one. The creature wails even if it is dead or unable to speak, no matter how far away from the trap it is. Unlike a casting of the spell, the drained condition from this trap's wail of the banshee spells increases the targets' drained condition values. A creature that critically succeeds at any of its saves can still be affected by the trap on future rounds, but can't be forced to wail by the trap." };
        }

        protected override void GetActions(InlineActionCollectionBuilder builder)
        {
            builder.Add(Guid.Parse("d403f5f2-59b1-446b-b31c-a91b8337c776"), ActionTypes.Instances.Reaction.ID, "Scream", action =>
            {
                action
                    .Trigger("Three or more living creatures remain within 100 feet of the trap for 6 seconds or longer")
                    .Details(details =>
                    {
                        details.Text(Guid.Parse("73e328d7-b078-4c03-a8ac-2f8f2191835e"), "The trap releases an arcane wail of the banshee (DC 40) with a 100-foot-radius emanation instead of 40 feet, targeting all living creatures in the area, and rolls initiative.");
                    });
            });
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("9f5a71e8-3044-4216-9aaa-846f17d46be1"),
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                DifficultyCheck = 30
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("d3d70679-6b55-4f37-9fc9-b1d7059535f5"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "to pierce the invisible larynx so precisely that the magic releases in a trickle before the trap activates",
                DifficultyCheck = 42
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f422309b-4d6f-42c6-820f-3870ac4d7891"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                Description = "three times to deconstruct the larynx while the trap is active in such a way that it tears the spell apart",
                DifficultyCheck = 44
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("0f0eee9b-3bb9-44b8-8674-8913633f6ba5"),
                Level = 9,
                Description = "to counteract the wail of the banshee before the trap activates",
                CounteractDifficultyCheck = 38
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dae57ffc-a1ec-4a36-87fb-6188e72dbd2a"),
                SourceId = CoreRulebook.ID,
                Page = 529
            };
        }
    }
}
