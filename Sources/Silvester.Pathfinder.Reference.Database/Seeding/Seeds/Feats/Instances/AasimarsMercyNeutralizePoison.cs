using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AasimarsMercyNeutralizePoison : Template
    {
        public static readonly Guid ID = Guid.Parse("d5588b80-1393-4a0e-a4c6-dde31e805faa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aasimar's Mercy - Neutralize Poison",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1cdca982-e127-45c6-9dc6-e6e784b7fd95"), Type = TextBlockType.Text, Text = "You can cast (spell: neutralize poison) as a 4th-level divine innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57a69d19-9011-4041-8251-d59967ce255f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
