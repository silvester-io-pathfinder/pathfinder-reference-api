using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class PalmAnObject : Template
    {
        public static readonly Guid ID = Guid.Parse("0147fb13-9526-4c95-8ad4-ed712b823a11");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Palm an Object",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6463dce3-3ddd-455d-b098-f1d7b0aa5eb1"), Type = TextBlockType.Text, Text = "Palming a small, unattended object without being noticed requires you to roll a single Thievery check against the Perception DCs of all creatures who are currently observing you. You take the object whether or not you successfully conceal that you did so. You can typically only Palm Objects of negligible Bulk, though the GM might determine otherwise depending on the situation." };
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
                Id = Guid.Parse("04edeab3-254b-4faa-90a4-bc4ff28a4d3a"),
                Success = "The creature does not notice you Palming the Object.",
                Failure = "The creature notices you Palming the Object, and the GM determines the creature�s response.",
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
                Id = Guid.Parse("a432254c-cc9f-4e4b-ae3a-3a10bc4b7ceb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 253
            };
        }
    }
}
