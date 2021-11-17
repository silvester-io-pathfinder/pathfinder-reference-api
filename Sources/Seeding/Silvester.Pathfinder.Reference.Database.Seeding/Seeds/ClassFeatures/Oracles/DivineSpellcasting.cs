using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class DivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("86d1a475-1e9d-4009-abb8-d40ab9d9d761");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Divine Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("819ecc76-49e6-413b-a50d-e59bfe24ac69"), Type = TextBlockType.Text, Text = "Your mystery provides you with divine magical power. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells. Your unconventional access to this divine power means you can usually replace material components with somatic components, so you don't need to use a material component pouch when casting spells." };
            yield return new TextBlock { Id = Guid.Parse("23955b89-7324-4365-8367-9f07dedccdf6"), Type = TextBlockType.Text, Text = "At 1st level, you can cast up to two 1st-level spells per day. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots. As you increase in level as an oracle, your number of spells per day increases, as does the highest level of spells you can cast, as shown on Table 2�3: Oracle Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse("c5a834ea-292e-4d00-abce-9c5a9c717ca4"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse("0b61ef05-1bff-4296-b8bf-2ba21f508a4d"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("33b229c9-0e28-4734-89d0-53208f424973"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. To cast a heightened spell, you must have the heightened version in your repertoire; for example, you can't cast a 3rd-level version of a spell that is only in your repertoire at 1st level. Many spells have specific improvements when they are heightened to certain levels. The signature spells class feature lets you heighten certain spells freely." };
            yield return new TextBlock { Id = Guid.Parse("1a8f7a8d-9560-441f-b6bc-be103d7a2ae1"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("be9a3981-aee8-45a2-9389-3b313ca50b47"), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up�this is usually equal to the highest level of oracle spell slot you have. For example, as a 1st-level oracle, your cantrips are 1st-level spells, and as a 5th-level oracle, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("e2aa3365-a8e7-45ca-b663-43c46a3e233d"), MagicTraditions.Instances.Divine.ID);

            //Cantrips.
            builder.GainSpecificSpellSlot(Guid.Parse("8e2a4728-d760-49c6-88fc-740e83e73101"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Regular spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse("e9c40922-c91e-4082-996e-ed02ea64ac90"), Guid.Parse("dad18b5b-bf40-4fd8-9cff-f8ce20da09bb"), requiredLevel: 1,  spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("911432ff-38ba-4812-bd99-4fa73f84aa13"), Guid.Parse("a55a4188-9a2f-4452-b5d4-2358be9c5d7a"), requiredLevel: 3,  spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("bddfc6ed-399a-46a0-a15a-2b32d1921f81"), Guid.Parse("dd5bfae6-7fed-4dbe-8624-65658864ceab"), requiredLevel: 5,  spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("8218aacb-af74-4ed2-9a71-b36702cb11d8"), Guid.Parse("4f8b6a9a-0eef-4c0d-a2dc-3c7c78fc16d5"), requiredLevel: 7,  spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("41e78ee5-80c4-4d74-86de-ef481e0c2be7"), Guid.Parse("7dd91070-8b78-48c6-bc61-b2912c5f26b5"), requiredLevel: 9,  spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("80043331-9266-4e32-b4ed-08b15881fbc4"), Guid.Parse("dbd16e7f-0129-4b87-9d41-2bc9a9aebb27"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("71312afa-bc3c-4046-a0d6-f5de298291f7"), Guid.Parse("e5ffd5a0-2a25-46e6-8f76-46e5be693010"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("6fc5871d-982b-42ea-8758-31294cfb835d"), Guid.Parse("e62c043d-7844-4324-ba03-dd896db09da2"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("897fde11-3de6-45cd-9d3d-a37e270c761f"), Guid.Parse("987a5951-f4a4-4213-80f6-126d1c457060"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb112277-28b5-494f-aa93-13a8d0794ced"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 68
            };
        }
    }
}
