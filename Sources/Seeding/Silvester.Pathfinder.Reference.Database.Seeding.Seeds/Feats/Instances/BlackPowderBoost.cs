using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackPowderBoost : Template
    {
        public static readonly Guid ID = Guid.Parse("fdd983dd-7546-4257-bb73-816f1d2a816a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Powder Boost",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "An ability that allows you to High Jump or Long Jump as a single action (like the Quick Jump skill feat) lets you use Black Powder Boost as a single action for those jumps as well.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("84c03627-73d6-4696-bbf5-8b2c67a7e082"), Type = TextBlockType.Text, Text = $"You fire your weapon as you jump, using the kickback to go farther. You {ToMarkdownLink<Models.Entities.Action>("Leap", Actions.Instances.Leap.ID)} and discharge your firearm to add a +10-foot status bonus to the distance traveled. If you spend 2 actions for Black Powder Boost, you {ToMarkdownLink<Models.Entities.SkillAction>("High Jump", SkillActions.Instances.HighJump.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Long Jump", SkillActions.Instances.LongJump.ID)} instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("608d3e35-4146-40c3-b8b5-3aa271164787"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
