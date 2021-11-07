using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBlue : Template
    {
        public static readonly Guid ID = Guid.Parse("126e7f3a-e9fe-401b-9d64-9bcfbb1d8c20");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Blue",
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
            yield return new TextBlock { Id = Guid.Parse("a4b30e65-7233-4830-8653-a8cf48678ca5"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a blue dragon." };
            yield return new TextBlock { Id = Guid.Parse("a333e9d8-285e-4b37-b16b-7aaae95d45d9"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("79f91f58-df5f-4e76-88a4-06b44cfd582f"), Type = TextBlockType.Text, Text = "~ Damage Type: Electricity" };
            yield return new TextBlock { Id = Guid.Parse("4120d734-c055-4e43-ad6c-bfc1b64b7091"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3ab4e7e0-95ef-434c-bd98-9f7129a8b841"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
