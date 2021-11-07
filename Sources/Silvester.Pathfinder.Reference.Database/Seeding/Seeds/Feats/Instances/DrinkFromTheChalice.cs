using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrinkFromTheChalice : Template
    {
        public static readonly Guid ID = Guid.Parse("ee5deba9-f031-4c97-828d-841d1af7d9bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drink from the Chalice",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca14e90f-2a67-4924-8920-fd3a36f68eb3"), Type = TextBlockType.Text, Text = "You drink from the liquid that slowly collects in your chalice or administer it to an adjacent ally. The drinker chooses whether to take a small sip or to drain the contents." };
            yield return new TextBlock { Id = Guid.Parse("75be6f08-1c30-46df-a014-5f1de47e89aa"), Type = TextBlockType.Enumeration, Text = " Sip: A sip grants the drinker an amount of temporary Hit Points equal to 2 + half your level that last until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("df2e2344-4c49-4be6-9601-1cdba1c0c3ff"), Type = TextBlockType.Enumeration, Text = " Drain: Drinking deep instead heals the drinker 3 Hit Points for each level you have. After the chalice is drained, it’s left with only its slowly collecting dregs; the chalice can’t be drained again, though it can still be sipped from. If 10 minutes pass without anyone drinking from the chalice, it refills itself and can be drained again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0aaf610e-4710-47be-bb0c-90df7d0b44cd"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
