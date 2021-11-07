using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrystallineDust : Template
    {
        public static readonly Guid ID = Guid.Parse("0e3b9fff-c12b-4ee5-adfb-6b9d75736747");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Crystalline Dust",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fc02b34-afd3-44d3-86c9-cd6a7020122d"), Type = TextBlockType.Text, Text = "You’ve learned to disperse the crystalline motes coating your body as a haze. You become concealed, though you can’t use this concealment to (action: Hide) or (action: Sneak), as normal for concealment where your position is still obvious. The motes stay within an inch of your skin, move with you, and last for a number of rounds equal to half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34acb0b5-940a-416b-838f-12dc1b649c25"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
