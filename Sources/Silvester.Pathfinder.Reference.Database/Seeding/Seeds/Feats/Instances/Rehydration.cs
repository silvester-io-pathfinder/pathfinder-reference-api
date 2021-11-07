using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Rehydration : Template
    {
        public static readonly Guid ID = Guid.Parse("40c50d0c-cb65-4255-a7ae-85d2c6f6ff66");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rehydration",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8901b645-91c2-4459-a788-99fa79b04a03"), Type = TextBlockType.Text, Text = "You surround your body with a thin layer of water drawn from the moisture in the air. You can spend one hour resting to rehydrate your gills and skin, which counts as submerging your body in water. At the GM’s discretion, incredibly dry areas, such as deserts, might not have enough moisture in the air for your Rehydration to work." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd2584fb-17f8-4c76-a4fe-c249a0034b16"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
