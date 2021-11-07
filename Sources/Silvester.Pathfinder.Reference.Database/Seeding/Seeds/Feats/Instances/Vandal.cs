using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Vandal : Template
    {
        public static readonly Guid ID = Guid.Parse("0ae3b11f-7297-4ef2-b3c6-5157fcaafdbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vandal",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db019f03-48b1-4ba7-91f1-e7de633b935f"), Type = TextBlockType.Text, Text = "You have a knack for breaking and dismantling things. Putting them back together is the boring part, so you largely don’t bother with that. You become trained in Thievery. If you would automatically become trained in Thievery (from your background or class, for example), you instead become trained in a skill of your choice. In addition, whenever you hit with a (action: Strike) against a trap or an unattended object, you ignore the first 5 points of the object’s Hardness." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7708cf1-3571-4a98-8eda-84beecf13be2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
