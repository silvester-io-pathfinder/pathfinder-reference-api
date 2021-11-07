using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SearingRestoration : Template
    {
        public static readonly Guid ID = Guid.Parse("b54e4908-7221-4870-bb44-2720d817caf8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Searing Restoration",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If your innovation is a minion, it can take this action rather than you, though because it's not a living creature, it can't use the ability on itself.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("154b2618-55a8-4c01-bd08-482c7b221dd8"), Type = TextBlockType.Text, Text = "They told you there was no way that explosions could heal people, but they were fools… Fools who didn’t understand your brilliance! You create a minor explosion from your innovation, altering the combustion to cauterize wounds using vaporized medicinal herbs. You or a living creature adjacent to you regains 1d10 Hit Points. In addition, the creature you heal can attempt an immediate flat check to recover from a single source of persistent bleed damage, with the DC reduction from appropriate assistance." };
            yield return new TextBlock { Id = Guid.Parse("a1ad3fa5-83b3-4592-97e0-ed9444a0fa6e"), Type = TextBlockType.Text, Text = "At 3rd level, and every 2 levels thereafter, increase the healing by 1d10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("effdb6cc-de1a-4735-bae9-1fe90850ef41"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
