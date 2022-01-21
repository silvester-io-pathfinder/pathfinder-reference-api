using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class MiraculousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("bed5a41b-049a-4aaf-99fd-2cf8bfc5a626");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Miraculous Spell", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("371b54f3-229a-4d98-b5b9-6b74f7db7dc2"), Type = TextBlockType.Text, Text = "You're exalted by your deity and gain truly incredible spells. You gain a single 10th-level spell slot and can prepare a spell in that slot using divine spellcasting. You can't use this spell slot for abilities that let you cast spells without expending spell slots or that give you more spell slots. You don't gain more 10th-level spells as you level up, though you can take the Maker of Miracles feat to gain a second slot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellSlot(Guid.Parse("531b4b5d-cc04-46e2-8f20-2ed9420e59e8"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e6e30fd-a1a1-4f0d-a1bf-19363f0b3321"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 121
            };
        }
    }
}
