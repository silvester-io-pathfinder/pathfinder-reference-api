using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpiritSheath : Template
    {
        public static readonly Guid ID = Guid.Parse("50a4cbae-60a5-494e-82cd-4843a786160d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spirit Sheath",
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
            yield return new TextBlock { Id = Guid.Parse("6be0e7e8-7ea8-47d9-9963-334a1092bb1f"), Type = TextBlockType.Text, Text = "You’ve magically constructed an extradimensional sheath for your weapon that you access through your clothing, typically through a pocket, sleeve, or seam. This sheath is hard to notice, granting a +2 circumstance bonus to your Stealth checks to (action: Conceal an Item | Conceal an Object) within it. A spirit sheath can hold only one weapon at a time, and the weapon must be 1 Bulk or less." };
            yield return new TextBlock { Id = Guid.Parse("c7e09c88-b290-49d9-801a-17c66d6e4062"), Type = TextBlockType.Text, Text = "During a (feat: Spellstrike), you can (action: Interact) to draw the weapon before you (action: Cast the Spell | Cast a Spell). You can draw or return a weapon in a spirit sheath as an (action: Interact) action, as can anyone else holding or wearing the clothing that contains the sheath. A (spell: dispel magic) spell or similar effect can be used against the spirit sheath to expel the weapon. The counteract check is made against your spell DC and uses the sheath’s counteract level of 1. The weapon is also expelled if you become unconscious." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99ef4ca9-7fd9-4a2a-8fe4-5ae15d94c1c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
