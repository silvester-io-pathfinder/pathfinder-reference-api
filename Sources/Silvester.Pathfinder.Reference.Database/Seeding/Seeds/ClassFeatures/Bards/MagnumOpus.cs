using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class MagnumOpus : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Magnum Opus", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have tuned your spellcasting to the highest caliber. Add two common 10th-level occult spells to your repertoire. You gain a single 10th-level spell slot you can use to cast one of those two spells using bard spellcasting. You don’t gain more 10th-level spells as you level up, unlike other spell slots, and you can’t use 10th-level slots with abilities that give you more spell slots or that let you cast spells without expending spell slots." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMagicTraditionSpell(Guid.Parse(""), MagicTraditions.Instances.Occult.ID, spellLevel: 10);
            builder.GainAnyMagicTraditionSpell(Guid.Parse(""), MagicTraditions.Instances.Occult.ID, spellLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 99
            };
        }
    }
}
