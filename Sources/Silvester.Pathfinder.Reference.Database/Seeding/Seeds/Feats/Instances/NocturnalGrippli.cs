using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NocturnalGrippli : Template
    {
        public static readonly Guid ID = Guid.Parse("386ef5d3-b5e3-4b32-bcf5-6f89dbfe5f50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nocturnal Grippli",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can take this feat only at 1st level, and you can't retrain out of this feat or into this feat.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a29b1ac7-e09c-4778-9dc4-fe95f5e9478a"), Type = TextBlockType.Text, Text = "You tend to do most of your hunting and work at night and have adapted to the requirements of nocturnal life. You gain darkvision, allowing you to see in darkness and dim light just as well as you can in bright light. However, in darkness, you see in black and white only." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8388af14-f3c9-4f8c-9726-298b22308099"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
