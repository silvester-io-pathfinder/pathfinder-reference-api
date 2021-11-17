using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SplinterFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("33f998eb-89a5-42bf-ab72-ab537b9c230b");

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
            yield return new TextBlock { Id = Guid.Parse("f18a9ee4-de58-4709-b3ec-35e7c7b26847"), Type = TextBlockType.Text, Text = "Your faith in your deity is represented in an extremely unusual way that some might call heretical. When you select this feat, you should detail the fundamental tenets of your splinter faith, though it shouldn’t affect the deity’s edicts or anathema. Choose four domains. These domains must be chosen from among your deity’s domains, your deity’s alternate domains, and up to one domain that isn’t on either list and isn’t anathematic to your deity. Any domain spell you cast from a domain that isn’t on either of your deity’s lists is always heightened to 1 level lower than usual for a focus spell." };
            yield return new TextBlock { Id = Guid.Parse("fac84ac8-1282-483f-9ac7-746bce5dab59"), Type = TextBlockType.Text, Text = "For the purpose of abilities that depend on your deity’s domains, the four domains you chose are your deity’s domains, and any of your deity’s domains you didn’t choose are now among your deity’s alternate domains." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c758c571-b578-4072-acfd-48a2367aea9d"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
