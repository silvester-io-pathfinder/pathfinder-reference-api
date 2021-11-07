using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FerociousGust : Template
    {
        public static readonly Guid ID = Guid.Parse("9bea005a-2937-4b64-8249-97cd2a12469d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ferocious Gust",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per 10 minutes"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc9ea76c-e041-4d25-a989-cbf92490c0d1"), Type = TextBlockType.Text, Text = "With heavy wing beats, you whip up a furious gust and direct it at your opponents. This air blast has the effects of (spell: gust of wind) with a DC equal to your class DC or spell DC, whichever is higher." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3a998fe-8759-4771-b100-b801172b938e"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
