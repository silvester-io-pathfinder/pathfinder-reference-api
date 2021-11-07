using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CounterThought : Template
    {
        public static readonly Guid ID = Guid.Parse("40da0d5c-b568-4bc2-b36c-67c3a98ccbc3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Counter Thought",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature Casts a Spell that has the mental trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5dd2470-bceb-4013-8767-d6f186dad166"), Type = TextBlockType.Text, Text = "When a foe (action: Casts a Spell | Cast a Spell) that has the (trait: mental) trait and you can see its manifestations, you can use your own mental magic to disrupt it. You expend one of your spell slots to counter the triggering creature’s casting of a spell with the (trait: mental) trait. You lose your spell slot as if you had cast the triggering spell; this spell slot must be one for which you could cast a spell with the (trait: mental) trait. You then attempt to counteract the triggering spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5aed1a63-b4d5-4ba0-a97e-cb0fcd6aad04"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
