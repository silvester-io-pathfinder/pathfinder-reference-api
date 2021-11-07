using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FellingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("b2fa9955-43ef-4ce2-9e3d-ed20c875c4c3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Felling Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fc979f72-8217-4b81-9f1b-cc5918d98e5e"), Type = TextBlockType.Text, Text = "Your attack can ground an airborne foe. Make a (Action: Strike). If it hits and deals damage to a flying target, the target falls up to 120 feet. The fall is gradual enough that if it causes the target to hit the ground, the target takes no damage from the fall. If the attack is a critical hit, the target can’t (Action: Fly), (Action: Leap), levitate, or otherwise leave the ground until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("330641d1-8e42-4d00-8722-67fd93e7a7f8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
