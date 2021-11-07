using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalEmbellish : Template
    {
        public static readonly Guid ID = Guid.Parse("c5dca6d0-8dfb-404c-ab53-ac35ac809b84");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Embellish",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9cf05053-3e2b-4bc5-bd1a-63d90820e503"), Type = TextBlockType.Text, Text = "You can summon a harmless but impressive elemental display. You become trained in Intimidation. If you would automatically become trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice. When you (action: Demoralize) a foe, if you choose to (action: Demoralize) via an elemental display, (action: Demoralize) loses the (trait: auditory) trait and gains the (trait: visual) trait, and you don’t take a penalty when you attempt to (action: Demoralize) a creature that doesn’t understand your language." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7aafbdb6-c5d5-45d5-8339-46304621502f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
