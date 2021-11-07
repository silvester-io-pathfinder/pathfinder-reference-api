using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RagingIntimidation : Template
    {
        public static readonly Guid ID = Guid.Parse("cf68e6b4-36d8-4cbb-b837-c68d96efa24a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Raging Intimidation",
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
            yield return new TextBlock { Id = Guid.Parse("8b2236d7-f1e4-497a-875c-91b85053a831"), Type = TextBlockType.Text, Text = "Your fury fills your foes with fear. While you are raging, your (Action: Demoralize) and (Feat: Scare to Death) actions gain the (trait: rage) trait, allowing you to use them while raging. As soon as you meet the prerequisites for the skill feats (Feat: Intimidating Glare) and (Feat: Scare to Death), you gain these feats." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0673e88f-4ce7-42b2-ae0b-cf79354e97b1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
