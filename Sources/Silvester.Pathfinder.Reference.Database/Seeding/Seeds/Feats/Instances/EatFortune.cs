using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EatFortune : Template
    {
        public static readonly Guid ID = Guid.Parse("1155a347-579a-43a8-9afc-817150125b2d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eat Fortune",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 60 feet uses a fortune or misfortune effect.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("658b33b8-e552-4378-8a02-2045713ef229"), Type = TextBlockType.Text, Text = "As someone tries to twist fate, you consume the interference. The triggering effect is disrupted. If it&#39;s a (trait: misfortune) effect, Eat Fortune gains the (trait: fortune) trait; if it&#39;s a (trait: fortune) effect, Eat Fortune gains the (trait: misfortune) trait. This fortune or misfortune applies to the same roll the triggering effect would have, so you couldn&#39;t negate a (trait: fortune) effect with Eat Fortune and then apply a (trait: misfortune) effect to the same roll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e1d9c59-41e8-4e09-bc5b-5dbe855c3b40"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
