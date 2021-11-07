using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stonecunning : Template
    {
        public static readonly Guid ID = Guid.Parse("c133c987-80b7-43c2-9dbc-368620ec5e3a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stonecunning",
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
            yield return new TextBlock { Id = Guid.Parse("165f3cab-52ec-4b02-9036-f8f0ca286c24"), Type = TextBlockType.Text, Text = "You have a knack for noticing even small inconsistencies and craftsmanship techniques in the stonework around you. You gain a +2 circumstance bonus to Perception checks to notice unusual stonework. This bonus applies to checks to discover mechanical traps made of stone or hidden within stone." };
            yield return new TextBlock { Id = Guid.Parse("467608a9-ab40-466d-80e5-2e49a4ce2655"), Type = TextBlockType.Text, Text = "If you aren’t using the (Action: Seek) action or searching, the GM automatically rolls a secret check for you to notice unusual stonework anyway. This check doesn’t gain the circumstance bonus, and it takes a –2 circumstance penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3a10b9a-2938-4519-b7d4-fbc66ce858f8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
