using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SorcererSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("4e82a527-db3e-466c-8cb9-36e4875a205b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Sorcerer Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a9f1b4f4-9a30-4c69-9485-c32a35ad0ba9"), Type = TextBlockType.Text, Text = "Your bloodline provides you with incredible magical power. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a sorcerer, you can usually replace material components with somatic components, so you don't need to use a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse("3df52f94-3ccb-4c21-a93c-ae2ee6616f89"), Type = TextBlockType.Text, Text = "Each day, you can cast up to three 1st-level spells. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("fd70eeab-d96c-41e4-b89e-5576e3ce5603"), Type = TextBlockType.Text, Text = "As you increase in level as a sorcerer, your number of spells per day increases, as does the highest level of spells you can cast, as shown on Table 3-17: Sorcerer Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse("10b942dc-9dcf-4f5e-b4ac-1540d99c0fb2"), Type = TextBlockType.Text, Text = "ome of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier." };
            yield return new TextBlock { Id = Guid.Parse("de6e9541-8e54-4f42-a23d-275cab74c555"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("a1a9512a-f9b1-429d-b10b-48f22ef65002"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level to match the spell slot. You must have a spell in your spell repertoire at the level you want to cast in order to heighten it to that level. Many spells have specific improvements when they are heightened to certain levels. The signature spells class feature lets you heighten certain spells freely." };
            yield return new TextBlock { Id = Guid.Parse("ca083017-fc37-427c-b157-479d4a240041"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("64da7dbf-2ac0-49a3-855b-6c7c99cb020b"), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up - this is usually equal to the highest level of sorcerer spell slot you have. For example, as a 1st-level sorcerer, your cantrips are 1st-level spells, and as a 5th-level sorcerer, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpellcastingAbility(Guid.Parse("a48f2599-7926-4e78-a07b-3458f93f3c14"), Stats.Instances.Charisma.ID);

            builder.GainSpecificSpellSlot(Guid.Parse("801c5d8d-c834-48ab-89da-98b6365b5008"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            builder.GainSpecificSpellSlot(Guid.Parse("018b6b71-a08b-4e74-9027-0820acba38d3"), Guid.Parse("6db5b59b-d761-482b-baa7-133a5727e2df"), requiredLevel: 1, spellSlotLevel: 1, amount: 3, increaseTo: 4, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("f35e98d4-2bb0-47de-a305-64aee45addaa"), Guid.Parse("8a443075-3f26-490c-a1ea-7f99f78d0614"), requiredLevel: 3, spellSlotLevel: 2, amount: 3, increaseTo: 4, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("2bb60544-c0ef-45d0-a855-0fae690238df"), Guid.Parse("880513e9-6307-4651-9d22-bf34215d0d12"), requiredLevel: 5, spellSlotLevel: 3, amount: 3, increaseTo: 4, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("e1f886bb-c83a-4ffe-985d-5d15e0fb9fa0"), Guid.Parse("4c6f93bc-4a6d-45c1-99cb-fabab2b2a303"), requiredLevel: 7, spellSlotLevel: 4, amount: 3, increaseTo: 4, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("055977d2-b43d-46a0-845b-fb5420fcaf60"), Guid.Parse("388239e4-455c-425a-bf78-b40a17bce7f8"), requiredLevel: 9, spellSlotLevel: 5, amount: 3, increaseTo: 4, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("848b9ba8-b626-4fcc-86b4-8b5b98e9e1f5"), Guid.Parse("c13b71ec-6791-4f77-a99e-a78e39f7250b"), requiredLevel: 11, spellSlotLevel: 6, amount: 3, increaseTo: 4, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("83bd3e60-61c1-4240-b23d-0d940644be5b"), Guid.Parse("2cb256fa-c783-4a74-a6e9-e9eb3478d998"), requiredLevel: 13, spellSlotLevel: 7, amount: 3, increaseTo: 4, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("59d4c0d0-2f9d-4b7c-a91e-de757758f944"), Guid.Parse("b9cf6403-cec9-421c-94ae-c8945b0b3bea"), requiredLevel: 15, spellSlotLevel: 8, amount: 3, increaseTo: 4, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("3ba69d0c-ad4d-4edc-a9ac-f665b4ccc169"), Guid.Parse("63adcff6-1517-4c17-95f3-bc297a2da4aa"), requiredLevel: 17, spellSlotLevel: 9, amount: 3, increaseTo: 4, atLevel: 18);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94221ab4-ad57-41fa-bb7c-14918f1958a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 192
            };
        }
    }
}
