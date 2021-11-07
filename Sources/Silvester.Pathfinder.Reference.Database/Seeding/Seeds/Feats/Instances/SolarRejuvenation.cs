using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SolarRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("1562bc2b-feae-4ea5-ba67-a4a111246bd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Solar Rejuvenation",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("575709a8-5730-4d71-bf03-c4312abd7e60"), Type = TextBlockType.Text, Text = "If you rest outdoors for 10 minutes during the day, you regain Hit Points equal to your Constitution modifier &#215; half your level. You gain this benefit in addition to any healing from (Action: Treat Wounds). Leshies whose plant nourishment does not rely on photosynthesis require a similarly suitable environment. For example, fungus leshies need dark, damp environments and a pile of decaying plant matter." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0525ddf5-7d15-44f2-8ced-31f86299d372"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
