using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class Steal : Template
    {
        public static readonly Guid ID = Guid.Parse("88d5be3a-ccc2-4a2a-8b93-b8c45ef96553");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Steal",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("25a54537-c4f2-473b-ab00-43d9a905eff7"), Type = TextBlockType.Text, Text = "You try to take a small object from another creature without being noticed. Typically, you can Steal only an object of negligible Bulk, and you automatically fail if the creature who has the object is in combat or on guard." };
            yield return new TextBlock { Id = Guid.Parse("4f879120-11cc-4991-9c04-9d6214ef6822"), Type = TextBlockType.Text, Text = "Attempt a Thievery check to determine if you successfully Steal the object. The DC to Steal is usually the Perception DC of the creature wearing the object. This assumes the object is worn but not closely guarded (like a loosely carried pouch filled with coins, or an object within such a pouch). If the object is in a pocket or similarly protected, you take a �5 penalty to your Thievery check. The GM might increase the DC of your check if the nature of the object makes it harder to steal (such as a very small item in a large pack, or a sheet of parchment mixed in with other documents)." };
            yield return new TextBlock { Id = Guid.Parse("e1d24d0c-4d40-49ee-b090-ee3ad9f71fe7"), Type = TextBlockType.Text, Text = "You might also need to compare your Thievery check result against the Perception DCs of observers other than the person wearing the object. The GM may increase the Perception DCs of these observers if they�re distracted." };
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
                Id = Guid.Parse("4b71a022-e748-468c-b71a-d449abbcf373"),
                Success = "You steal the item without the bearer noticing, or an observer doesn�t see you take or attempt to take the item.",
                Failure = "The item�s bearer notices your attempt before you can take the object, or an observer sees you take or attempt to take the item. The GM determines the response of any creature that notices your theft.",
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
                Id = Guid.Parse("6ef5619a-55fb-46c6-8c82-8d1ea3d1ea40"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 253
            };
        }
    }
}
