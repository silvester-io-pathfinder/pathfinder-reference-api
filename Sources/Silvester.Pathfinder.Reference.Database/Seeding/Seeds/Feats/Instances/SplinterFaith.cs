using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplinterFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("6f191ff5-d77d-4e06-9d3e-b4c54799661e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Splinter Faith",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "Unless you take this feat at 1st level, changing the way you relate to your deity requires retraining by changing  your faith. If you take this feat and previously benefited from any effect that requires a domain your splinter faith doesn't include, such as a domain spell from Domain Initiate, you lose that effect.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a2cdacdd-20c5-40d0-bf9c-c5471a13b96b"), Type = TextBlockType.Text, Text = "Your faith in your deity is represented in an extremely unusual way that some might call heretical. When you select this feat, you should detail the fundamental tenets of your splinter faith, though it shouldn’t affect the deity’s edicts or anathema. Choose four domains. These domains must be chosen from among your deity’s domains, your deity’s alternate domains, and up to one domain that isn’t on either list and isn’t anathematic to your deity. Any domain spell you cast from a domain that isn’t on either of your deity’s lists is always heightened to 1 level lower than usual for a focus spell." };
            yield return new TextBlock { Id = Guid.Parse("8d418a60-74b8-400a-8005-4c9151b57374"), Type = TextBlockType.Text, Text = "For the purpose of abilities that depend on your deity’s domains, the four domains you chose are your deity’s domains, and any of your deity’s domains you didn’t choose are now among your deity’s alternate domains." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95a3da98-433f-4f12-87a8-d32df2b56a80"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
