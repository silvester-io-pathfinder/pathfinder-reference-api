using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class ConcealAnObject : Template
    {
        public static readonly Guid ID = Guid.Parse("56f912aa-c2f5-4676-b9bb-c39c17b7622b");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Conceal an Object",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("735efa09-4374-4c6f-aa3c-d7e771e3868e"), Type = TextBlockType.Text, Text = "You hide a small object on your person (such as a weapon of light Bulk). When you try to sneak a concealed object past someone who might notice it, the GM rolls your Stealth check and compares it to this passive observer's Perception DC. Once the GM rolls your check for a concealed object, that same result is used no matter how many passive observers you try to sneak it past. If a creature is specifically searching you for an item, it can attempt a Perception check against your Stealth DC (finding the object on success)." };
            yield return new TextBlock { Id = Guid.Parse("529129de-1009-4f10-a6f3-7b469290912b"), Type = TextBlockType.Text, Text = "You can also conceal an object somewhere other than your person, such as among undergrowth or in a secret compartment within a piece of furniture. In this case, characters Seeking in an area compare their Perception check results to your Stealth DC to determine whether they find the object." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Manipulate.ID;
            yield return Traits.Instances.Secret.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("ae58617a-56e6-4e14-aeee-92afb4c6bd70"),
                Success = "The object remains undetected.",
                Failure = "The searcher finds the object.",
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
                Id = Guid.Parse("28b749da-5918-4f08-94af-060e89af3538"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 251
            };
        }
    }
}
