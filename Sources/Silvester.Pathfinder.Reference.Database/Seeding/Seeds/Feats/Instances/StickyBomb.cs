using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StickyBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("a0428412-5139-4b83-a015-d59957799920");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sticky Bomb",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical bomb, and that bomb's level is at least 2 levels lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e08026b1-eaf1-47ba-8e61-c7e26c53c218"), Type = TextBlockType.Text, Text = "You mix in an additive to make your bomb’s contents adhere to the target and continue to deal damage. A creature that takes a direct hit from one of your sticky bombs also takes persistent damage equal to and of the same type as the bomb’s splash damage. If the bomb already deals persistent damage, combine the two amounts." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab522bdf-711c-41d0-8fe6-e9e13118800f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
