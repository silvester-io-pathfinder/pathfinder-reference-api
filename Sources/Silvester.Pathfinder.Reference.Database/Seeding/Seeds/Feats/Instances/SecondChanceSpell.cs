using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondChanceSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("ec8d29d9-fb90-4225-97c4-3bff66361896");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Chance Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b37ceb9e-77f6-4331-a9e3-d947f8de8ef5"), Type = TextBlockType.Text, Text = "When your target proves resilient to your magical deceptions, you can try them again on someone else. When you cast an (trait: enchantment) spell that targets one creature and that creature critically succeeds at its Will save, you can (activity: Cast a Spell) again before the end of your next turn on a different creature without expending an additional spell slot. The second casting doesn’t grant you any benefits that you would normally gain for (activity: Casting a Spell | Cast a Spell) from a spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("080a9118-341c-42c0-8fa7-52fecdae0858"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
