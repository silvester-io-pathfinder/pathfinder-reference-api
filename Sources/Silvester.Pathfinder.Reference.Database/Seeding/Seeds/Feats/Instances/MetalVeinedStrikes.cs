using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MetalVeinedStrikes : Template
    {
        public static readonly Guid ID = Guid.Parse("f3359a40-ed84-400d-84a4-ab983ff04103");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Metal-Veined Strikes",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a1a8bf97-2ac6-4ca4-b2b9-d16cbe3c1510"), Type = TextBlockType.Text, Text = "Metallic veins grow throughout your body, giving your unarmed attacks a metallic sheen. Choose either cold iron or silver. Your unarmed attacks are treated as the chosen type of metal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b16929c-521d-4cfa-8fd6-910f51a9bc98"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
