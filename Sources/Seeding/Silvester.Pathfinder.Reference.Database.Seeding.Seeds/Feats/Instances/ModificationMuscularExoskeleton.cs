using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMuscularExoskeleton : Template
    {
        public static readonly Guid ID = Guid.Parse("47584358-b672-422f-9a8f-a0d9984cb497");

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
            yield return new TextBlock { Id = Guid.Parse("dd62e6c3-e301-4d72-bda5-e06ffa106df4"), Type = TextBlockType.Enumeration, Text = "*Power Suit Only**" };
            yield return new TextBlock { Id = Guid.Parse("e0cb3e37-4ff8-4c3f-b187-9c1215419b77"), Type = TextBlockType.Text, Text = "Your armor supports your muscles with a carefully crafted exoskeleton. When you send your armor into overdrive, the exoskeleton supplements your feats of athletics as well. When under the effects of (action: Overdrive), you gain a +1 circumstance bonus to Athletics checks; if you're a master in Crafting, this increases to a +2 circumstance bonus." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("349da6fd-5222-427c-af51-3f1631680f56"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
