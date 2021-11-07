using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AasimarsMercyRemoveDisease : Template
    {
        public static readonly Guid ID = Guid.Parse("99cc350d-46fd-4f1b-87bd-073f5af81578");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aasimar's Mercy - Remove Disease",
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
            yield return new TextBlock { Id = Guid.Parse("5e09c639-91f9-49c7-bc15-a494fdc41ae9"), Type = TextBlockType.Text, Text = "You can cast (spell: remove disease) as a 4th-level divine innate spell once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2897f5d2-fba3-486d-87d6-eefd1e60248b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
