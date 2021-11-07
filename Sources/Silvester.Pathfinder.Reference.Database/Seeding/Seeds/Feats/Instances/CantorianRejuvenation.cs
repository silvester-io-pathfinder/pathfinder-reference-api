using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CantorianRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("ad49fe63-7472-4893-bf2e-03cc6965c481");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cantorian Rejuvenation",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0749452b-2129-4642-a364-59f52f924045"), Type = TextBlockType.Text, Text = "The life-giving energy that flows in your blood revitalizes you. You recover 4d6 Hit Points and gain 10 temporary Hit Points for 1 minute. When you reach 15th level, you instead recover 6d6 HP and gain 15 temporary HP." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d10aec2b-3ab9-41fa-8f76-df673df75854"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
