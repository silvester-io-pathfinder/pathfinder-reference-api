using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenPaces : Template
    {
        public static readonly Guid ID = Guid.Parse("f96106b7-e66e-4687-b8d5-af8da4c69cff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ten Paces",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18b95a54-a1d8-43e0-b60d-cf6a7f4def6c"), Type = TextBlockType.Text, Text = "You react to trouble with lightning speed, positioning yourself just right. You gain a +2 circumstance bonus to your initiative roll, and you can (action: Interact) to draw a one-handed firearm or one-handed crossbow. As your first action on your first turn, you can (action: Step) up to 10 feet as a free action." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("daf10ad8-940f-4f51-baf2-54a7d32060b3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
