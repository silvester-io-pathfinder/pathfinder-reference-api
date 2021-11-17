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
using Silvester.Pathfinder.Reference.Database.Extensions;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArcaneSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("838cf44f-ce60-4a97-b5ec-f4d5ead61c68");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Arcane Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d500917c-b9b4-43aa-875a-f10cce482db0"), Type = TextBlockType.Text, Text = "Through dedicated study and practice, you can harness arcane power to cast spells. You can cast arcane spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells." };
            yield return new TextBlock { Id = Guid.Parse("fab3fde8-15da-4895-b6cd-575bb36da1b5"), Type = TextBlockType.Text, Text = "At 1st level, you can prepare up to two 1st-level spells and five cantrips each morning from the spells in your spellbook (see below), plus one extra cantrip and spell of your chosen school of each level you can cast if you are a specialist wizard. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("473579a8-6aac-4e22-8de8-962060d974ee"), Type = TextBlockType.Text, Text = "As you increase in level as a wizard, your number of spell slots and the highest level of spells you can cast from spell slots increase." };
            yield return new TextBlock { Id = Guid.Parse("9b011aa7-9dbc-4782-9155-900d82fc8d64"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Intelligence, your spell attack rolls and spell DCs use your Intelligence modifier." };
            yield return new TextBlock { Id = Guid.Parse("3f20b7a8-de7d-49d9-8271-efaa6b50f11b"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("2894d5a3-b1cd-431a-b78f-7e0388d6ed52"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse("fa86dda9-ccd9-435e-b692-c3a947e3e296"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("ae2f3f5f-0be3-42f8-871c-836ed8e31788"), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up�this is usually equal to the highest level of wizard spell slot you have. For example, as a 1st-level wizard, your cantrips are 1st-level spells, and as a 5th-level wizard, your cantrips are 3rd-level spells." };
            yield return new TextBlock { Id = Guid.Parse("50ca93b4-e9d9-4758-96e6-170c7179e79e"), Type = TextBlockType.Heading, Text = "Spellbook" };
            yield return new TextBlock { Id = Guid.Parse("23d5d30e-53a1-49e2-91f8-0bd971ed191a"), Type = TextBlockType.Text, Text = "Every arcane spell has a written version, usually recorded in a spellbook. You start with a spellbook worth 10 sp or less, which you receive for free and must study to prepare your spells each day. The spellbook contains your choice of 10 arcane cantrips and five 1st-level arcane spells. You choose these from the common spells on the arcane spell list from this book or from other arcane spells you gain access to. Your spellbook's form and name are up to you. It might be a musty, leather-bound tome or an assortment of thin metal disks connected to a brass ring; its name might be esoteric, like The Crimson Libram, or something more academic, like A Field Study in Practical Transmutation." };
            yield return new TextBlock { Id = Guid.Parse("dc0c2301-f53d-4006-8dd9-e2fa25d04854"), Type = TextBlockType.Text, Text = "Each time you gain a level, you add two more arcane spells to your spellbook, of any level for which you have spell slots. You can also use the Arcana skill to add other spells that you find in your adventures (See Learn a Spell)." };
            yield return new TextBlock { Id = Guid.Parse("fa1a2737-ee9b-4912-8dbd-105392b5e3ea"), Type = TextBlockType.Heading, Text = "Sample Spellbook" };
            yield return new TextBlock { Id = Guid.Parse("ec243a29-154b-42c9-9546-a7178312f990"), Type = TextBlockType.Text, Text = "You can fill your spellbook with whichever spells you like, but the list below covers a good selection of starter spells for a 1st-level wizard. These are the exact spells found in Structure and Interpretation of Arcane Magic, a basic spellbook used by arcane academies and master wizards to teach apprentices good habits in arcane research." };
            yield return new TextBlock { Id = Guid.Parse("987c6d9b-d1bb-41d8-843b-11545ff3cfcb"), Type = TextBlockType.Text, Text = "Cantrips: Acid splash, detect magic, electric arc, light, mage hand, message, prestidigitation, ray of frost, read aura, and shield." };
            yield return new TextBlock { Id = Guid.Parse("3be16c69-9d28-48f8-999a-b99fb26db820"), Type = TextBlockType.Text, Text = "1st Level: Burning hands, color spray, grease, mage armor, and magic missile, plus one spell of your school if you�re a specialist wizard." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("5151b0ad-e520-4823-b446-0fa9e9cd5335"), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpellBook(Guid.Parse("eba3b1fa-dc54-40d1-abd0-d35dde0e11ab"), cantripAmount: 10, spellAmount: 5, addSpellsPerLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("581e0c3b-c3ec-4a3c-a33d-a967cca865b7"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);
            builder.GainSpecificSpellSlot(Guid.Parse("654259e1-79da-4a1e-818c-971e2b8424cd"), amount: 1, spellSlotLevel: 0, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse("b6b0d9f0-0c6b-4fd5-82a5-a0bf4f435a72"), prerequisites => 
                {
                    prerequisites.HaveAnyMagicSchool(Guid.Parse("505415a6-afc6-4838-85c5-134dfc6ba1e6"));
                });

            builder.GainSpecificSpellSlot(Guid.Parse("022c9473-3715-4875-ae90-a1223805de0c"), Guid.Parse("5d4a265e-101e-4a74-989d-5f9b45ff9a6f"), requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("a6fc5fe7-0d3e-4dc4-9bac-c6f797bc7b9e"), Guid.Parse("3b2e3124-2a91-4b21-b8b7-7d1bf74aeb3f"), requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("dff559ce-274c-4778-8ac0-71fe58aa1a73"), Guid.Parse("31dec55f-060e-4589-8911-7b4b1640a5b5"), requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("27894e25-1dff-4419-8ef5-7a649111cb02"), Guid.Parse("27a77b89-01a6-4c3c-a10b-de234415c398"), requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("3bdb98f7-9016-4459-97b4-333a634e5f55"), Guid.Parse("9403a82a-da0c-41b8-86f8-5919e17f2f60"), requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("3b1b16be-55c2-4079-8ed4-07a59b4dd436"), Guid.Parse("3bf0dafc-8814-4029-9e52-a00004b353d0"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("876e6a00-53e6-4eb2-8044-3d1a35c111d0"), Guid.Parse("71f966d1-99c7-4909-a7bc-ecf8e15ccf70"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("5c691cdd-c89e-4a33-85a3-63cbf29c0117"), Guid.Parse("7c2417b8-ced7-46fa-bde2-d0827b252f4c"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("989ac8de-8ace-4100-b054-589ea4c6f0bc"), Guid.Parse("c107e266-d122-4d55-96d9-ee7e12b4efe5"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
          
            builder.GainSpecialistSpellSlot(Guid.Parse("8f51f69b-9f7b-45bf-bbc6-c61e49f8dc69"), Guid.Parse("6d53d76c-267b-465d-9637-ed5e1a11208b"), requiredLevel: 5, spellSlotLevel: 3);
            builder.GainSpecialistSpellSlot(Guid.Parse("d6d42ee5-cc65-4d8a-bbee-be220d7c8e0e"), Guid.Parse("295a081b-a0f3-460c-90a7-e6bedc0fbaab"), requiredLevel: 1, spellSlotLevel: 1);
            builder.GainSpecialistSpellSlot(Guid.Parse("f84d2a8a-ff8e-4edf-985e-66b3890b0601"), Guid.Parse("eb3705ac-698e-4575-a13d-1beb557cb016"), requiredLevel: 3, spellSlotLevel: 2);
            builder.GainSpecialistSpellSlot(Guid.Parse("69c0a515-aaf5-4675-a903-248119e638e0"), Guid.Parse("5b54d279-459c-4085-8352-c5361dde75d8"), requiredLevel: 7, spellSlotLevel: 4);
            builder.GainSpecialistSpellSlot(Guid.Parse("9c6aac0a-c1c1-42a3-9f3c-2b27ad1de52e"), Guid.Parse("e7359ee4-31b2-4260-a1f4-d100434b135c"), requiredLevel: 9, spellSlotLevel: 5);
            builder.GainSpecialistSpellSlot(Guid.Parse("64a51f5a-86ff-4126-a8d8-75806b376c23"), Guid.Parse("3559f021-893b-4bcb-ae72-a7cb03ab357d"), requiredLevel: 11, spellSlotLevel: 6);
            builder.GainSpecialistSpellSlot(Guid.Parse("acb6fc0d-9a99-4d63-86ba-7cab681045d0"), Guid.Parse("9f4e85a1-8168-4b50-8fe0-9d63bb4a7a85"), requiredLevel: 13, spellSlotLevel: 7);
            builder.GainSpecialistSpellSlot(Guid.Parse("b832fce2-354c-46f9-b7c3-9a3e0f0a2afe"), Guid.Parse("5405e0c3-6a2f-4114-9e36-84f2bfc299f8"), requiredLevel: 15, spellSlotLevel: 8);
            builder.GainSpecialistSpellSlot(Guid.Parse("35290c52-77c8-4692-a088-2b181945f4f9"), Guid.Parse("7d45917d-e4c6-4b85-bd71-56de05c9c44b"), requiredLevel: 17, spellSlotLevel: 9);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eeb8a353-7262-44f4-9c92-35471c51af73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 204
            };
        }
    }

    public static partial class BooleanEffectBuilderExtensions
    {
        public static void GainSpecialistSpellSlot(this BooleanEffectBuilder builder, Guid id, Guid prerequisiteId, int requiredLevel, int spellSlotLevel)
        {
            builder.GainSpecificSpellSlot(id, amount: 1, spellSlotLevel, isSpendingPreventable: true)
                .AddPrerequisites(id.Increment(1), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
                    prerequisites.HaveAnyMagicSchool(prerequisiteId);
                });
        }
    }
}
