using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class WitchSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("d0016490-3386-4b2b-9901-6c20865a8146");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Witch Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1122da80-f0cd-4418-946a-9ae452902040"), Type = TextBlockType.Text, Text = "Using your familiar as a conduit, your patron provides you the power to cast spells. You can cast spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells." };
            yield return new TextBlock { Id = Guid.Parse("854d8d37-7528-4a51-a00f-a63e35979aac"), Type = TextBlockType.Text, Text = "At 1st level, you can prepare up to two 1st-level spells and five cantrips each morning from the spells your familiar knows. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("41c6a20f-47bb-4114-8a62-bb86dae53f2f"), Type = TextBlockType.Text, Text = "As you increase in level as a witch, your number of spell slots and the highest level of spells you can cast from spell slots increase, as shown in Table 2-7: Witch Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse("ac79dd15-6204-4ca8-a20c-af50d7bbaf0b"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Intelligence, your spell attack rolls and spell DCs use your Intelligence modifier." };
            yield return new TextBlock { Id = Guid.Parse("650f8f2a-98c2-423c-ae95-fc229c0ff0ce"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("2f92892f-7cdf-4d0d-a78f-cfe39d1fae91"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse("c23f33b9-24d5-41c1-91a3-4f6f7551c1fb"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("0312e32e-640c-4113-8766-45cf3f9f7eb9"), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up - this is usually equal to the highest level of witch spell slot you have. For example, as a 1st-level witch, your cantrips are 1st-level spells, and as a 5th-level witch, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Spellcasting ability
            builder.GainSpellcastingAbility(Guid.Parse("1f03e454-a66a-48f8-b0a9-482ef696cd38"), Stats.Instances.Intelligence.ID);
            
            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse("87f4a508-1f75-4020-aed7-ea6217f7cc38"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse("09d546bc-ed7b-4f06-ba1b-78525b4a92f7"), Guid.Parse("69ce0d2a-e753-4233-97f0-04a8ccae3f6e"), requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("7ac2bed3-18c6-4821-9580-d0534d2830d8"), Guid.Parse("30a9d29d-56f6-47ee-becc-fd7e3339f464"), requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("5d0f2db8-d8be-47f0-bef2-3daa058d32a5"), Guid.Parse("fa8e3b4f-149f-47c7-a2aa-998cf91d418c"), requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("bf8de768-51cf-49bd-8c2d-734f0d8b0ebb"), Guid.Parse("adeffc66-bc30-4758-ae74-305b8b6f88de"), requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("667f003e-5961-47ef-9b76-19ab66d4ff54"), Guid.Parse("5063da98-9702-447c-a837-ba1eac2a395a"), requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("d0d6e3da-b361-4296-ad7a-78075e59fb6d"), Guid.Parse("765413c8-8332-41f9-9513-304435191670"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("cfca422c-08c5-4df3-a5c2-b9cd496c8143"), Guid.Parse("501d20e3-da5e-4041-af29-70c631b4a0b5"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("d9abc894-6b95-4385-9ff4-86c6420c6593"), Guid.Parse("813d5ab9-1c29-4007-a051-e3f3ed69fa89"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("a5709479-3e87-427f-9d66-386364bca5ef"), Guid.Parse("a1c31f70-d470-487a-9e1d-21b6adcbdb7f"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62737789-d318-4449-868c-8b578eaeadcf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
