using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SummonerSpellcaster : Template
    {
        public static readonly Guid ID = Guid.Parse("39911dd2-5f71-4f50-96e3-a7eb37413dd9");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Summoner Spellcaster", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("78c57683-b95c-4174-9e1b-f3f994dfe4ee"), Type = TextBlockType.Text, Text = "Your link to your eidolon grants you limited magic connected to your eidolon's nature. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells. Because of the magic you draw from your eidolon, you can usually replace material components with somatic components, so you don't need a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse("7ba1e40a-04cf-45f9-8a85-2d45d438e48c"), Type = TextBlockType.Text, Text = "Each day, you can cast one 1st-level spell and five cantrips. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("26b817a4-006b-41c2-bcd8-deed818b6ee7"), Type = TextBlockType.Text, Text = "As you increase in level as a summoner, the magical link with your eidolon grants you additional, more powerful spell slots. Your total number of spell slots and the highest level of spells you can cast are shown in Table 2-4: Summoner Spells per Day. Because of the way you draw magic from your connection to your eidolon, you begin to lose lower-level spell slots once you reach 5th level. The maximum number of spell slots you get from the summoner class is four, starting when you reach 4th level." };
            yield return new TextBlock { Id = Guid.Parse("f6338ab0-b431-416c-ba9a-83fe40905118"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier. " };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse("da2b2642-c2d4-4de1-ac15-a68c9aabe27b"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spells
            builder.GainSpecificSpellSlot(Guid.Parse("5c103708-7806-4408-9d43-dab46285d8a1"), Comparator.EqualTo, requiredLevel: 1, spellSlotLevel: 1, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("cca48ef2-2f19-468b-9d00-4179020b8031"), Comparator.EqualTo, requiredLevel: 2, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("eaae65ac-48a5-49c9-89eb-e3eb1faccf44"), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("05108956-8c67-4251-a1d2-75f9a843b3ef"), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 2, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("5cf33ca3-d6f2-4a4c-9700-1cf796c7e311"), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ee094d30-87df-4fba-a7a8-05d5f6d12bf5"), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("51aa46ec-9a10-463f-b436-8af23dacf3f9"), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ab441166-efa3-44c3-a444-3cf0953b0aaf"), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("50cca7e0-c655-4497-ae7f-92e210861cc1"), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ba393374-dc7e-49e0-a045-ba43e8360051"), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("7a8d14f8-efec-4a0e-87f5-83e0997ebb08"), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("c43c876c-c207-4ef3-a13e-cc53b908a164"), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("0fef483a-9dad-4623-8ded-7d62bfd8031a"), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("05f8be6b-262e-4c31-bca9-e8db6722c3b1"), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ed072551-9450-493f-80b1-f48454d1a65d"), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("b5cf5536-a5d3-44a2-9094-02a68c563533"), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("2206b557-32b4-41d4-9788-afbd1aad057c"), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("9ea5b048-4354-4049-bcb1-f7d6d087ba31"), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("86e87bde-697a-4475-92ee-c43a063ed577"), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("8f751daf-8003-4b19-adcb-80cc466fcc06"), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("37a2196d-fb1d-4625-9c18-56bbba620f7c"), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("7dcd61ea-7dc7-4f36-8d9a-7209260cb0b7"), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("f181b00d-d0cf-4e00-91a9-5225f8147dcc"), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ce408ace-cf75-4c02-a5e5-3c13b70fa027"), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("231a7c9f-4ca3-494a-aef3-2f52a91d6801"), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("769e494b-d5c4-4021-a275-049835cc43c1"), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("188f7818-0dbd-4b40-aa6b-30d6150e277d"), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("ae8b2941-87ec-4d52-af50-3ded95931bd1"), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("c58aa50d-9487-464c-a0b7-483a266cbe26"), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("0a23a7b3-78c9-4f94-9d9d-e79b07d7065c"), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("f6cd68fb-3939-427a-958c-4d20dff01766"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("29f7dbde-9474-417f-866a-b989038c177b"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 9, amount: 2);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40656f9a-f800-4eca-b3a9-2e87aebe23cd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 207
            };
        }
    }
}
