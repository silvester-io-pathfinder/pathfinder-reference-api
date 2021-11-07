using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMuscularExoskeleton : Template
    {
        public static readonly Guid ID = Guid.Parse("5d559c04-17a3-49eb-bfd2-ccbf6c22c4d9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Muscular Exoskeleton",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5dbf7d02-f7d1-4251-8f14-08f931d9e89c"), Type = TextBlockType.Enumeration, Text = "*Power Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("e4f39140-1716-4159-80a7-fc2ba847a539"), Type = TextBlockType.Text, Text = "Your armor supports your muscles with a carefully crafted exoskeleton. When you send your armor into overdrive, the exoskeleton supplements your feats of athletics as well. When under the effects of (action: Overdrive), you gain a +1 circumstance bonus to Athletics checks; if you’re a master in Crafting, this increases to a +2 circumstance bonus." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a239b9e-d52f-4349-99cb-df252e657494"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
