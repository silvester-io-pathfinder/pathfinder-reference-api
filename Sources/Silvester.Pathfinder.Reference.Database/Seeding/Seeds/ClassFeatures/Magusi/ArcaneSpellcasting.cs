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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You study spells so you can combine them with your attacks or solve problems that strength of arms alone can't handle. You can cast arcane spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells. Because you're a magus, you can draw replacement sigils with the tip of your weapon or your free hand for spells requiring material components, replacing them with somatic components instead of needing a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, you can prepare one 1st-level spell and five cantrips each morning from the spells in your spellbook (see below). Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a magus, your number of spell slots and the highest level of spells you can cast from spell slots increase, shown in Table 2–2: Magus Spells per Day. Because you split your focus between physical training and magical scholarship, you have no more than two spell slots of your highest level and, if you can cast 2nd-level spells or higher, two spell slots of 1 level lower than your highest spell level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Your spell attack rolls and spell DCs use your Intelligence modifier. Details on calculating these statistics appear in Spell Attack Roll." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they're heightened to certain levels." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is always automatically heightened to half your level rounded up—this is usually equal to the highest level of spell you can cast as a magus. For example, as a 1st-level magus, your cantrips are 1st-level spells, and as a 5th-level magus, your cantrips are 3rd-level spells." };

            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Spellbook" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Every arcane spell has a written version, usually recorded in a spellbook. You start with a spellbook worth 10 sp or less, which you receive for free and must study to prepare your spells each day. The spellbook contains your choice of eight arcane cantrips and four 1st-level arcane spells. You choose these from the common spells on the arcane spell list or from other arcane spells you gain access to. Your spellbook's form and name are up to you. It might be anything from a sturdy book with a secure latch entitled Theses on the Stratagems of Supernatural Warfare to a tattered collection of training pamphlets with your name scrawled on the cover." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time you gain a level, you add two more arcane spells to your spellbook, of any level of spell you can cast. You can also use the Arcana skill to add other spells that you find in your adventures (see Learn a Spell). Though you lose some lower spell slots as you increase in level, you keep the spells in your spellbook and can prepare them in your higher-level slots as normal." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you have a spellbook from multiple sources (such as being a magus with the Wizard Dedication feat), you can use the same spellbook for all your spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse(""), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpellBook(Guid.Parse(""), cantripAmount: 8, spellAmount: 4, addSpellsPerLevel: 2);

            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse(""), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spell slots
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 1, spellSlotLevel: 1, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 2, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 2, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 9, amount: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 36
            };
        }
    }
}
