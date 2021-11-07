using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackCatCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("e0bed515-77aa-4ec8-81ba-6fe5463742a4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Cat Curse",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within 30 feet you can see would succeed at a save.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3d96dab2-1824-4ba0-b04a-0beeedb046b6"), Type = TextBlockType.Text, Text = "You hiss a spiteful curse at the creature. The target must reroll the triggering saving throw and use the worse result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("795fcc4b-7451-479c-b438-6aaab5f4ce5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
