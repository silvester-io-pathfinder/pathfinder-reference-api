using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class OccultSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("d0ca23ad-ee68-4069-8268-bae355981a55");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Occult Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("18cdf065-6aeb-4e27-ab8e-0cd5a0e26202"), Type = TextBlockType.Text, Text = "You draw upon magic from esoteric knowledge. You can cast occult spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a bard, you can usually play an instrument for spells requiring somatic or material components, as long as it takes at least one of your hands to do so. If you use an instrument, you don't need a material component pouch or another hand free. You can usually also play an instrument for spells requiring verbal components, instead of speaking." };
            yield return new TextBlock { Id = Guid.Parse("82ae52a7-c736-42b7-8668-289eed50750e"), Type = TextBlockType.Text, Text = "Each day, you can cast up to two 1st-level spells. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("e65bba4e-2674-4a8a-9aa8-b3c95c0c8ed7"), Type = TextBlockType.Text, Text = "As you increase in level as a bard, your number of spells per day increases, as does the highest level of spells you can cast." };
            yield return new TextBlock { Id = Guid.Parse("d5f75a0e-805c-453c-81ec-e2fd4703b499"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier. Details on calculating these statistics are found under Spell Attack Rolls." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("e6f556de-75c5-41cb-81e8-54271309668f"), MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSpellSlot(Guid.Parse("5a145fd3-4d13-4714-b10d-eee4a10241ef"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            builder.GainSpecificSpellSlot(Guid.Parse("fff53ad0-feaa-4bfa-8d21-ed3f03d14a92"), Guid.Parse("6660552a-2adb-452f-a858-1d61c06c6a2e"), requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("63f3b0f1-f54a-48e8-a08c-d5741af0597d"), Guid.Parse("181f0ba6-4d57-4f7f-bbae-d09eebc6a994"), requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("161a030a-613a-46b1-b86c-8c634d9c76d5"), Guid.Parse("513d1524-bc62-4fc5-9322-a5530efc4045"), requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("dd97d0b7-51a0-41d5-ac48-d772740b2bac"), Guid.Parse("7b606453-7bc4-4e90-8cae-7e7f87ff49a9"), requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("38fa144b-a955-4355-8287-732a86881434"), Guid.Parse("13ca2364-ee81-41da-b3c6-bb526be79751"), requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("aad56fb0-7537-464b-9ae3-2e91563cba57"), Guid.Parse("d446a82a-8409-4689-8ada-0f48f8bc07c0"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("cdc159e4-7e2c-4823-914b-c524ba7bd78d"), Guid.Parse("1b8ae9f5-f606-4701-bb3e-fdfd23ce1287"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("54fe2106-4270-4982-a561-233279f3fd7a"), Guid.Parse("00f0cc87-ce6a-4d98-8a41-8ead4022654c"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("d3d01972-90ec-4927-9bde-632bbebb4ae1"), Guid.Parse("77c229cc-11c6-4ac2-9dea-37e5a1e5d611"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3418c72-9975-43d5-83aa-7c035bd3bc3a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
            };
        }
    }
}
