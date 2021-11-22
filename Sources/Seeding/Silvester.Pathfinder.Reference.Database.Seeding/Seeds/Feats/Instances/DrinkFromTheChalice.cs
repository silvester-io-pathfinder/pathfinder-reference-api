using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrinkFromTheChalice : Template
    {
        public static readonly Guid ID = Guid.Parse("1804bf62-a1ed-48be-b4b5-0f13553b6cbb");

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
            yield return new TextBlock { Id = Guid.Parse("f492073d-56a7-4906-8035-4e6eac226a14"), Type = TextBlockType.Text, Text = "You drink from the liquid that slowly collects in your chalice or administer it to an adjacent ally. The drinker chooses whether to take a small sip or to drain the contents." };
            yield return new TextBlock { Id = Guid.Parse("912d4173-f447-488b-9b97-2b48c5112917"), Type = TextBlockType.Enumeration, Text = " Sip: A sip grants the drinker an amount of temporary Hit Points equal to 2 + half your level that last until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("b1648d1e-2aa3-4e5d-946f-ebd66cb1c033"), Type = TextBlockType.Enumeration, Text = " Drain: Drinking deep instead heals the drinker 3 Hit Points for each level you have. After the chalice is drained, it's left with only its slowly collecting dregs; the chalice can't be drained again, though it can still be sipped from. If 10 minutes pass without anyone drinking from the chalice, it refills itself and can be drained again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab882c8f-cd6d-4e0d-9159-8301b80958dd"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
