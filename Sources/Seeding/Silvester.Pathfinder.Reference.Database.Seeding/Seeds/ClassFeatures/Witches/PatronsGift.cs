using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class PatronsGift : Template
    {
        public static readonly Guid ID = Guid.Parse("ed63ef11-0976-4f09-948f-a93b730bcd35");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 19,
                Name = "Patron's Gift", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d01071b0-1bdb-4c13-a86b-c75a2ab68a41"), Type = TextBlockType.Text, Text = "Your patron grants you the power to command incredible works of magic. You gain a single 10th-level spell slot and can prepare a spell in that slot using witch spellcasting. Unlike with other spell slots, these spell slots can't be used for abilities that let you cast spells without expending spell slots or abilities that give you more spell slots. You don't gain more 10th-level spells as you level up, though you can take the Patron's Truth feat to gain a second slot." };

        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellSlot(Guid.Parse("29a209f7-d899-46d5-9d48-4c4154a13617"), amount: 1, spellSlotLevel: 10, isSpendingPreventable: false);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d7e392e7-81a7-4f89-bc8e-bfd11cbe9740"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
