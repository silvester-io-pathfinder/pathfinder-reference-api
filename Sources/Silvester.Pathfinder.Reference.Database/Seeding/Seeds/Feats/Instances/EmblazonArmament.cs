using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmblazonArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("05e1790a-0970-48ae-890d-f13197581981");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emblazon Armament",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ec6c932-b7a1-4bb5-921d-bc5378978bf7"), Type = TextBlockType.Text, Text = "Carefully etching a sacred image into a physical object, you steel yourself for battle. You can spend 10 minutes emblazoning a symbol of your deity upon a weapon or shield. The symbol doesn’t fade until 1 year has passed, but if you Emblazon an Armament, any symbol you previously emblazoned and any symbol already emblazoned on that item instantly disappears. The item becomes a religious symbol of your deity and can be used as a divine focus while emblazoned, and it gains another benefit determined by the type of item. This benefit applies only to followers of the deity the symbol represents." };
            yield return new TextBlock { Id = Guid.Parse("c22d273c-131f-4a73-ae7d-6c5e4984500a"), Type = TextBlockType.Enumeration, Text = " Shield: The shield gains a +1 status bonus to its Hardness. (This causes it to reduce more damage with the (action: Shield Block) reaction.)" };
            yield return new TextBlock { Id = Guid.Parse("94841404-6414-4a32-9cc1-ef8f5827de42"), Type = TextBlockType.Enumeration, Text = " Weapon: The wielder gains a +1 status bonus to damage rolls." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("67ffe5f5-af16-4147-8cd2-ab022c45eccb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
