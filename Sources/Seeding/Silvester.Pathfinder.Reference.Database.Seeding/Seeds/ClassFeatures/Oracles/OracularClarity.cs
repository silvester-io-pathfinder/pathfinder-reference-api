using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class OracularClarity : Template
    {
        public static readonly Guid ID = Guid.Parse("b06f00da-5948-4c20-8e98-c8cac6bf04ad");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Oracular Clarity", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6cac65d2-8e02-4646-a21b-cfc15d6f5119"), Type = TextBlockType.Text, Text = "You now fully grasp the nature of the divine power behind your mystery, allowing you to work magic akin to miracles. Add two common 10th-level divine spells to your repertoire. You gain a single 10th-level spell slot you can use to cast one of those two spells using oracle spellcasting. You don't gain more 10th-level spells as you level up, unlike other spell slots, and you can't use 10th-level slots with abilities that give you more spell slots or that let you cast spells without expending spell slots. You can take the Oracular Providence feat to gain a second slot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("e782c482-8b81-4d96-8b82-5efd13add47d"), MagicTraditions.Instances.Divine.ID, spellLevel: 10);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse("14c45515-1e2c-49f9-9ed7-2ecfb10a75df"), MagicTraditions.Instances.Divine.ID, spellLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("16fc816a-e23e-4724-9cfe-d2a64367405f"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("843bc52e-fa44-4cf6-81c5-7cc4dc7b15f9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 72
            };
        }
    }
}
