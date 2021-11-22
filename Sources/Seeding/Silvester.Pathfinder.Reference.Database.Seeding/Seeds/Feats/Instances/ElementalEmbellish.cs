using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalEmbellish : Template
    {
        public static readonly Guid ID = Guid.Parse("a22b5b13-c4fb-4f3f-8f0c-bcb1537b6b30");

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
            yield return new TextBlock { Id = Guid.Parse("ca0281f2-03e7-4592-935b-203e5932693f"), Type = TextBlockType.Text, Text = "You can summon a harmless but impressive elemental display. You become trained in Intimidation. If you would automatically become trained in Intimidation (from your background or class, for example), you instead become trained in a skill of your choice. When you (action: Demoralize) a foe, if you choose to (action: Demoralize) via an elemental display, (action: Demoralize) loses the (trait: auditory) trait and gains the (trait: visual) trait, and you don't take a penalty when you attempt to (action: Demoralize) a creature that doesn't understand your language." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("041bd2b6-3067-4181-b1c5-74fc0082bef0"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
