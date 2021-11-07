using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PackRat : Template
    {
        public static readonly Guid ID = Guid.Parse("22baa230-cf33-4755-9306-97c0ed4bf553");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Rat",
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
            yield return new TextBlock { Id = Guid.Parse("81ee036c-063a-4bf6-9bf8-bedc1cf30677"), Type = TextBlockType.Text, Text = "Years of packing for travel have taught you how to cram vast quantities into small spaces. You can fit an additional 50% of the listed Bulk capacity into mundane storage containers or vehicles. For example, you can fit 6 Bulk in a (item: backpack), or 12 Bulk in a (item: chest | wooden chest). This doesn&#39;t alter the items&#39; Bulk, nor does it change how much you can store in a (trait: magical) or (trait: extradimensional) storage space, such as a (item: bag of holding | Bag of Holding I)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c8eb704-643a-4dbb-8646-013878654cf5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
