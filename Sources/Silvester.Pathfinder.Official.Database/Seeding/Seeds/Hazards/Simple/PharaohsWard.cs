using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class PharaohsWard : Template
    {
        public static readonly Guid ID = Guid.Parse("58875d5f-9989-4476-bafe-451b2746e393");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Pharaoh's Ward",
                Description = "A curse is imbued on an entryway’s threshold.",
                Level = 7,
                Reset = "The trap resets when the door is shut.",
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Traps.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
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
            yield return Traits.Instances.Mechanical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("deb0f675-09fc-450b-90d2-e04da0e1c699"),
                Name = "Curse the Intruders",
                Traits = FilterTraits("Curse", "Divine", "Necromancy"),
                Trigger = "The seal on the tomb is broken from the outside",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("d9095071-f339-42ec-99a9-b36054c97766"), Type = TextBlockType.Text, Text = "Each living creature within 60 feet must succeed at a DC 23 Will save or be subjected to the pharaoh’s curse. A cursed creature takes a –2 status penalty to Fortitude saves, and any natural or magical healing it receives is halved. The curse remains until removed by remove curse or similar magic." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("88214882-6a74-4455-9e37-f263eaf5fb07"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 25
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("b4c7e3c6-0802-41b6-be1b-635af1dbc1cb"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "To painstakingly remove the lintel without triggering the magic.",
                DifficultyCheck = 27
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("6fe47838-2cc2-46ff-abaf-1ded872463e8"),
                Level = 4,
                Description = "To counteract the rune.",
                CounteractDifficultyCheck = 25
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("375da921-2ed7-4ac7-87c5-c738a30e095c"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
