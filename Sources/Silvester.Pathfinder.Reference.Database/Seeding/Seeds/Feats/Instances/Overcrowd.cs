using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Overcrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("e0549f28-0155-495d-a6f5-385db9dbbff8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overcrowd",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ce9b2f24-c342-4ea5-b769-735594062714"), Type = TextBlockType.Text, Text = "Your physiology is slight, and you can pack into small spaces with others of similar stature. As long as you are Small, you can end your movement in the same square as a Small ally. Only two creatures total can share the same space when using this ability or a similar one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f954f4d-35e7-4495-9c92-47fb7a7f92d4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
