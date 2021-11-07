using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SolarRejuvenation : Template
    {
        public static readonly Guid ID = Guid.Parse("846b2b83-7816-4ba1-97bc-4be804985c0a");

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
            yield return new TextBlock { Id = Guid.Parse("5a746ac5-406b-457f-ae00-c62f98c9c17e"), Type = TextBlockType.Text, Text = "If you rest outdoors for 10 minutes during the day, you regain Hit Points equal to your Constitution modifier &#215; half your level. You gain this benefit in addition to any healing from (Action: Treat Wounds). Leshies whose plant nourishment does not rely on photosynthesis require a similarly suitable environment. For example, fungus leshies need dark, damp environments and a pile of decaying plant matter." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e39ad662-35eb-4335-8492-5bfd970009fd"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
