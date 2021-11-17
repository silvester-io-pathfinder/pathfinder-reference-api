using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArchwizardsSpellcraft : Template
    {
        public static readonly Guid ID = Guid.Parse("a415cb44-8cb4-4633-a39e-2076d6271355");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Archwizard's Spellcraft", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("30a860b4-5dca-44e9-a68b-585f4e6aa2c8"), Type = TextBlockType.Text, Text = "You command the most potent arcane magic and can cast a spell of truly incredible power. You gain a single 10th-level spell slot and can prepare a spell in that slot using arcane spellcasting. You can't use this spell slot for abilities that let you cast spells without expending spell slots or that give you more spell slots. Unlike with other spell slots, you don't gain more 10th-level spells as you level up, though you can take the Archwizard's Might feat to gain a second slot." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellSlot(Guid.Parse("b744f6af-d96a-4b5b-8e33-2b0c06f703d4"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b60ec52-367e-43c5-ba5c-7f9a5b7997bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
