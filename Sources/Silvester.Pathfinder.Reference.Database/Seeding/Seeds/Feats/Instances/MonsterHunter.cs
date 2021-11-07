using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonsterHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("78695623-a576-4f76-a100-62e5febd7b69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monster Hunter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54ecd47c-6101-4d5a-a0d5-5175d59b8d30"), Type = TextBlockType.Text, Text = "You swiftly assess your prey and apply what you know. As part of the action used to (feat: Hunt your Prey | Hunt Prey), you can attempt a check to (action: Recall Knowledge) about your prey." };
            yield return new TextBlock { Id = Guid.Parse("0f85a3ff-1bc3-49ec-852a-5a1edd609335"), Type = TextBlockType.Text, Text = "When you critically succeed at identifying your hunted prey with (action: Recall Knowledge), you note a weakness in the creature’s defenses. You and allies you tell may gain a +1 circumstance bonus to your next attack roll against that prey. You can give bonuses from Monster Hunter only once per day against a particular creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("445e962a-a50f-4382-8d71-13b66aad80e8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
