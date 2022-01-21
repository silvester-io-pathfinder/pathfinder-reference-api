using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class DisableADevice : Template
    {
        public static readonly Guid ID = Guid.Parse("30cf1115-5512-46d4-982d-9a5c750f0e2c");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Disable a Device",
                Requirements = "Some devices require you to use thieves� tools (page 291) when disabling them.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cc473d69-5c1f-4c66-8722-c078f8457789"), Type = TextBlockType.Text, Text = "This action allows you to disarm a trap or another complex device. Often, a device requires numerous successes before becoming disabled, depending on its construction and complexity. Thieves� tools are helpful and sometimes even required to Disable a Device, as determined by the GM, and sometimes a device requires a higher proficiency rank in Thievery to disable it." };
            yield return new TextBlock { Id = Guid.Parse("08aa82f2-b850-4dd9-8c5c-e0e40c90441c"), Type = TextBlockType.Text, Text = "Your Thievery check result determines how much progress you make." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Thievery.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("92f0b6a1-dd43-44b0-96e5-f0fcc5500a05"),
                CriticalSuccess = "You disable the device, or you achieve two successes toward disabling a complex device. You leave no trace of your tampering, and you can rearm the device later, if that type of device can be rearmed.",
                Success = "You disable the device, or you achieve one success toward disabling a complex device.",
                CriticalFailure = "You trigger the device."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d80c664-67c1-4957-8fd0-e00a9f4585ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 253
            };
        }
    }
}
