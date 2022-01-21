using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("128139fc-e6d2-4f77-80b1-9f681f7d99fb");

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
            yield return new TextBlock { Id = Guid.Parse("e58de7ac-64a4-4444-b6fc-5f7d302a7653"), Type = TextBlockType.Text, Text = "Your deity bestows on you the power to cast divine spells. You can cast divine spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a cleric, you can usually hold a divine focus (such as a religious symbol) for spells requiring material components instead of needing to use a material component pouch. At 1st level, you can prepare two 1st-level spells and five cantrips each morning from the common spells on the divine spell list in this book or from other divine spells to which you gain access. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("0d671f1c-6eed-430b-82e5-34264a7ec68f"), Type = TextBlockType.Text, Text = "As you increase in level as a cleric, the number of spells you can prepare each day increases, as does the highest level of spell you can cast, as shown in Table 3�9: Cleric Spells per Day on page 120." };
            yield return new TextBlock { Id = Guid.Parse("efa7792e-dccc-4a06-9c34-dd416924b4e1"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or your enemies to roll against your spell DC (typically by attempting a saving throw). Since your key ability is Wisdom, your spell attack rolls and spell DCs use your Wisdom modifier." };
            yield return new TextBlock { Id = Guid.Parse("520c231d-cc6a-4e82-9ff6-0f8a4a1bb62a"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("5ba89537-6bb1-403f-bcfc-34f8aa620a33"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse("ab606e92-6cf5-4c47-adc4-6cb94086b260"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("1684ccfd-ec90-497b-966f-0e9763df15e3"), Type = TextBlockType.Text, Text = "A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is always automatically heightened to half your level rounded up�this is usually equal to the highest level of cleric spell slot you have. For example, as a 1st-level cleric, your cantrips are 1st-level spells, and as a 5th-level cleric, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("8c41ffb5-4c8b-40b2-8424-03803605f476"), MagicTraditions.Instances.Divine.ID);

            //Cantrips.
            builder.GainSpecificSpellSlot(Guid.Parse("3a877992-0ecf-46f2-85c0-1e5bfe8b5fc6"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Regular spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse("989514b2-5da6-4aea-ba1b-7bcbe77ddbc5"), Guid.Parse("2d06a38c-bf92-4a90-a8fc-80b8f7fcd3f9"), requiredLevel: 1,  spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("d7e1fea6-d703-4682-87c0-e04233a4dcca"), Guid.Parse("5f6a03b2-bbf0-45d9-80f9-5be73fcc5e47"), requiredLevel: 3,  spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("13b74a73-598a-4474-aa7c-8c34b6ee0f05"), Guid.Parse("213a1771-c590-4ac2-87a8-625df550ea6e"), requiredLevel: 5,  spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("aff31c51-aee5-45b8-9a12-e67e2b7f8767"), Guid.Parse("6a814433-cf63-4795-9429-bbc60ce7027e"), requiredLevel: 7,  spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("0f20dc19-3a89-4f98-9510-51de2b97ad7f"), Guid.Parse("c8c08d9d-b0ef-455d-928d-8ad6f80374f1"), requiredLevel: 9,  spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("7c19d1d4-8515-49fb-88d2-02f2708163c4"), Guid.Parse("5d0f691d-992c-49ad-9cfd-440db190b5cd"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("d85b807a-9624-4787-9376-f4ca396d3c61"), Guid.Parse("a2135abd-0377-46f6-9107-8f8c490cb9c0"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("4477ff96-15e6-4e20-ad10-e54f57f1a694"), Guid.Parse("6b83fcd8-d92a-458f-8e4a-a6493a6a0863"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("00109110-a5e1-4833-b209-ccc174aa9640"), Guid.Parse("77789365-5ae8-455f-9fac-4256b4772220"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);

            //Divine font spell slots. These are prerequisited to be active only at their specific levels.
            builder.GainDivineFontSpellSlot(Guid.Parse("6b0f8310-40e6-4d65-817f-fffb2e1ddb1b"), Guid.Parse("fb7d89ad-dda0-476e-9adf-420db945722f"), exactRequiredLevel: 1,  spellSlotLevel: 1);
            builder.GainDivineFontSpellSlot(Guid.Parse("4ae6c695-6321-4579-8c6e-3fc02df2e8e7"), Guid.Parse("0859448e-3e09-4998-84cc-87c62dedd4c8"), exactRequiredLevel: 2,  spellSlotLevel: 1);
            builder.GainDivineFontSpellSlot(Guid.Parse("1298a629-693d-4794-aab9-ff6ddde5f2b2"), Guid.Parse("2c66e26c-3fae-40c1-9a9a-0a9b841d95bb"), exactRequiredLevel: 3,  spellSlotLevel: 2);
            builder.GainDivineFontSpellSlot(Guid.Parse("69b775f4-f13d-4918-8ce1-e4f06ade3863"), Guid.Parse("ed79d2a3-d51c-4d4b-bad6-84ef09cad03d"), exactRequiredLevel: 4,  spellSlotLevel: 2);
            builder.GainDivineFontSpellSlot(Guid.Parse("7e9c84eb-a658-4275-8d66-0c41a668ee8b"), Guid.Parse("b8bde416-c4af-4ea4-ad64-5bbb4b6f124a"), exactRequiredLevel: 5,  spellSlotLevel: 3);
            builder.GainDivineFontSpellSlot(Guid.Parse("f4041c58-bc4c-42e1-9815-65ca56b0c582"), Guid.Parse("a570ccde-c10f-429e-a372-77f7aac37fdc"), exactRequiredLevel: 6,  spellSlotLevel: 3);
            builder.GainDivineFontSpellSlot(Guid.Parse("8b402f4e-0a9b-410e-b52d-5be29dcf5d84"), Guid.Parse("68bebd91-9092-4fba-8f59-55aa358083fa"), exactRequiredLevel: 7,  spellSlotLevel: 4);
            builder.GainDivineFontSpellSlot(Guid.Parse("b0e1f655-4bc3-4d04-8f12-824a36673261"), Guid.Parse("c65d71d1-d53d-4baf-aaf9-e69bdcc52d3e"), exactRequiredLevel: 8,  spellSlotLevel: 4);
            builder.GainDivineFontSpellSlot(Guid.Parse("055add37-3a17-4d7b-ab9a-353b729696cf"), Guid.Parse("f1c151ac-b12d-4c03-9300-1be5844b0ebe"), exactRequiredLevel: 9,  spellSlotLevel: 5);
            builder.GainDivineFontSpellSlot(Guid.Parse("54d43481-b507-4650-a337-1f5228b06a28"), Guid.Parse("a40f24cc-de87-4602-9b50-dbd600ecb6b5"), exactRequiredLevel: 10, spellSlotLevel: 5);
            builder.GainDivineFontSpellSlot(Guid.Parse("6ad50cdd-7bb0-48e8-ba20-933a3586e4ad"), Guid.Parse("1aa8ce81-b24f-4957-9d4b-f78b349d7bc7"), exactRequiredLevel: 11, spellSlotLevel: 6);
            builder.GainDivineFontSpellSlot(Guid.Parse("dfaf31c0-b7ac-4d69-a2fc-916e3a9caf93"), Guid.Parse("8b8bee81-b8f8-4dc2-9a48-b1bbc2656925"), exactRequiredLevel: 12, spellSlotLevel: 6);
            builder.GainDivineFontSpellSlot(Guid.Parse("02332078-9165-469b-b23f-c151a37cd877"), Guid.Parse("89174145-5704-45a6-87a5-d1df73e316ea"), exactRequiredLevel: 13, spellSlotLevel: 7);
            builder.GainDivineFontSpellSlot(Guid.Parse("ccef4bdc-4b4d-46ee-a8cb-62a493c48dde"), Guid.Parse("9f77dff0-af39-4381-a70f-76098b261292"), exactRequiredLevel: 14, spellSlotLevel: 7);
            builder.GainDivineFontSpellSlot(Guid.Parse("a5561640-2dfb-43ab-94e7-c6b04d6cf466"), Guid.Parse("cfdb020a-4ada-4b7a-8a15-e2c378f6453c"), exactRequiredLevel: 15, spellSlotLevel: 8);
            builder.GainDivineFontSpellSlot(Guid.Parse("28453cb0-5d1d-49ab-9e4b-6d20fc6a60cd"), Guid.Parse("41243d8d-a952-46fb-83ee-d5bda6aa42b0"), exactRequiredLevel: 16, spellSlotLevel: 8);
            builder.GainDivineFontSpellSlot(Guid.Parse("59721659-4a64-4fb6-992f-143943da40ce"), Guid.Parse("567423e8-c4e3-482d-9731-4fbcb8edcad1"), exactRequiredLevel: 17, spellSlotLevel: 9);
            builder.GainDivineFontSpellSlot(Guid.Parse("4e14b459-547d-462e-ad61-973eecc26d78"), Guid.Parse("a27db4c1-33e2-45a8-a151-4f11a3ab906f"), exactRequiredLevel: 18, spellSlotLevel: 9);
            builder.GainDivineFontSpellSlot(Guid.Parse("7c22ea54-d116-4f24-b81b-8688065e5614"), Guid.Parse("a91b3417-c4cb-4538-a779-d108d9e7f3d1"), exactRequiredLevel: 19, spellSlotLevel: 10);
            builder.GainDivineFontSpellSlot(Guid.Parse("759c8754-3db4-48d5-ba09-750ad800728d"), Guid.Parse("d30f91d5-9d42-4514-b988-6e45a1445e90"), exactRequiredLevel: 20, spellSlotLevel: 10);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d52b302-ffe2-4acc-82fa-ed817fb1e8f2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }
    }
}
