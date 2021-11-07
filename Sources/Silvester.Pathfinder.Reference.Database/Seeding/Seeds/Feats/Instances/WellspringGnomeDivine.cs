using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellspringGnomeDivine : Template
    {
        public static readonly Guid ID = Guid.Parse("e894c644-95b4-42d3-a327-0b9813177768");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wellspring Gnome - Divine",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2657cb13-f788-4c13-ae85-8a64b32caff3"), Type = TextBlockType.Text, Text = "You gain one cantrip from the divine spell list. You can cast this spell as an innate spell at will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ac4c2462-fc22-468c-846a-13998363ec0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
