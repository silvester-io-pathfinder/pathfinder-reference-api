using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class TreatWounds : Template
    {
        public static readonly Guid ID = Guid.Parse("5821fa7f-3064-4e42-bf44-0d7ebacd1b37");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Treat Wounds",
                Requirements = "You�re wearing or holding healer�s tools (page 290).",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("09a6162f-29c2-4f23-acdf-82f18b30ed17"), Type = TextBlockType.Text, Text = "You spend 10 minutes treating one injured living creature (targeting yourself, if you so choose). The target is then temporarily immune to Treat Wounds actions for 1 hour, but this interval overlaps with the time you spent treating (so a patient can be treated once per hour, not once per 70 minutes)." };
            yield return new TextBlock { Id = Guid.Parse("ce90fdef-5658-43cd-b5d5-305f5a3d4d79"), Type = TextBlockType.Text, Text = "The Medicine check DC is usually 15, though the GM might adjust it based on the circumstances, such as treating a patient outside in a storm, or treating magically cursed wounds. If you�re an expert in Medicine, you can instead attempt a DC 20 check to increase the Hit Points regained by 10; if you�re a master of Medicine, you can instead attempt a DC 30 check to increase the Hit Points regained by 30; and if you�re legendary, you can instead attempt a DC 40 check to increase the Hit Points regained by 50. The damage dealt on a critical failure remains the same." };
            yield return new TextBlock { Id = Guid.Parse("c22163f0-bb6b-4242-8540-80736493cb92"), Type = TextBlockType.Text, Text = "If you succeed at your check, you can continue treating the target to grant additional healing. If you treat them for a total of 1 hour, double the Hit Points they regain from Treat Wounds." };
            yield return new TextBlock { Id = Guid.Parse("69a85794-8340-4729-a378-6ae0275b8efc"), Type = TextBlockType.Text, Text = "The result of your Medicine check determines how many Hit Points the target regains." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("f0262cff-eb4f-4b92-a34e-f0a919b889af"),
                CriticalSuccess = "The target regains 4d8 Hit Points, and its wounded condition is removed.",
                Success = "The target regains 2d8 Hit Points, and its wounded condition is removed.",
                CriticalFailure = "The target takes 1d8 damage."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c0b7377-0abd-4b15-9ed7-a4feb0c25f4a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 249
            };
        }
    }
}
