using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarrenNavigator : Template
    {
        public static readonly Guid ID = Guid.Parse("e2e91b2f-c918-4628-9527-b3fc8f0c4474");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warren Navigator",
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
            yield return new TextBlock { Id = Guid.Parse("9891d21a-5cd6-4e86-abe2-65fe7c47ea74"), Type = TextBlockType.Text, Text = "You&#39;re particularly good at solving mazes and navigating twists and turns. You gain the trained proficiency rank in Survival. If you would automatically become trained in Survival (from your background or class, for example), you become trained in another skill of your choice. When you (action: Sense Direction) or attempt a roll against a (spell: maze) spell, you get a result one degree of success better than you rolled. You don&#39;t take a penalty to (action: Sense Direction) when you lack a (item: compass)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff5d0efb-b3f8-4e6d-bcf0-50fbe10afd52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
