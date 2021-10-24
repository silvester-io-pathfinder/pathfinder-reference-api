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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArcaneSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Arcane Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Through dedicated study and practice, you can harness arcane power to cast spells. You can cast arcane spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, you can prepare up to two 1st-level spells and five cantrips each morning from the spells in your spellbook (see below), plus one extra cantrip and spell of your chosen school of each level you can cast if you are a specialist wizard. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a wizard, your number of spell slots and the highest level of spells you can cast from spell slots increase." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Intelligence, your spell attack rolls and spell DCs use your Intelligence modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up—this is usually equal to the highest level of wizard spell slot you have. For example, as a 1st-level wizard, your cantrips are 1st-level spells, and as a 5th-level wizard, your cantrips are 3rd-level spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Spellbook" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Every arcane spell has a written version, usually recorded in a spellbook. You start with a spellbook worth 10 sp or less, which you receive for free and must study to prepare your spells each day. The spellbook contains your choice of 10 arcane cantrips and five 1st-level arcane spells. You choose these from the common spells on the arcane spell list from this book or from other arcane spells you gain access to. Your spellbook's form and name are up to you. It might be a musty, leather-bound tome or an assortment of thin metal disks connected to a brass ring; its name might be esoteric, like The Crimson Libram, or something more academic, like A Field Study in Practical Transmutation." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time you gain a level, you add two more arcane spells to your spellbook, of any level for which you have spell slots. You can also use the Arcana skill to add other spells that you find in your adventures (See Learn a Spell)." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Sample Spellbook" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can fill your spellbook with whichever spells you like, but the list below covers a good selection of starter spells for a 1st-level wizard. These are the exact spells found in Structure and Interpretation of Arcane Magic, a basic spellbook used by arcane academies and master wizards to teach apprentices good habits in arcane research." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Cantrips: Acid splash, detect magic, electric arc, light, mage hand, message, prestidigitation, ray of frost, read aura, and shield." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "1st Level: Burning hands, color spray, grease, mage armor, and magic missile, plus one spell of your school if you’re a specialist wizard." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpellBook(Guid.Parse(""), cantripAmount: 10, spellAmount: 5, addSpellsPerLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 1, spellSlotLevel: 0, isSpendingPreventable: true)
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveAnyMagicSchool(Guid.Parse(""));
                });

            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
          
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5, spellSlotLevel: 3);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 1, spellSlotLevel: 1);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 3, spellSlotLevel: 2);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7, spellSlotLevel: 4);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9, spellSlotLevel: 5);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11, spellSlotLevel: 6);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13, spellSlotLevel: 7);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15, spellSlotLevel: 8);
            builder.GainSpecialistSpellSlot(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17, spellSlotLevel: 9);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
                .AddPrerequisites(Guid.Parse(""), prerequisites => 
                {
                    prerequisites.HaveSpecificLevel(id, Comparator.GreaterThanOrEqualTo, requiredLevel);
                    prerequisites.HaveAnyMagicSchool(prerequisiteId);
                });
        }
    }
}
