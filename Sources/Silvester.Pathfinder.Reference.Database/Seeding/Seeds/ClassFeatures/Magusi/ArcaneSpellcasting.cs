using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSpellCastingEffect
            {
                Id = Guid.Parse(""),
                MagicTraditionId = MagicTraditions.Instances.Arcane.ID
            };

            yield return new GainSpellBookEffect
            {
                Id = Guid.Parse(""),
                CantripAmount = 8,
                SpellAmount = 4,
                AddSpellsPerLevel = 2
            };

            //Cantrips
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 5,
                Level = 0,
                IsSpendingPreventable = true
            };

            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 1, amount: 1, slotLevel: 1, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 2, amount: 2, slotLevel: 1, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 3, amount: 2, slotLevel: 1, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 3, amount: 1, slotLevel: 2, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 4, amount: 2, slotLevel: 1, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 4, amount: 2, slotLevel: 2, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 5, amount: 2, slotLevel: 2, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 5, amount: 2, slotLevel: 3, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 6, amount: 2, slotLevel: 2, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 6, amount: 2, slotLevel: 3, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 7, amount: 2, slotLevel: 3, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 7, amount: 2, slotLevel: 4, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 8, amount: 2, slotLevel: 3, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 8, amount: 2, slotLevel: 4, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 9, amount: 2, slotLevel: 4, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 9, amount: 2, slotLevel: 5, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 10, amount: 2, slotLevel: 4, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 10, amount: 2, slotLevel: 5, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 11, amount: 2, slotLevel: 5, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 11, amount: 2, slotLevel: 6, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 12, amount: 2, slotLevel: 5, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 12, amount: 2, slotLevel: 6, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 13, amount: 2, slotLevel: 6, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 13, amount: 2, slotLevel: 7, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 14, amount: 2, slotLevel: 6, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 14, amount: 2, slotLevel: 7, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 15, amount: 2, slotLevel: 7, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 15, amount: 2, slotLevel: 8, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 16, amount: 2, slotLevel: 7, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.EqualTo, atLevel: 16, amount: 2, slotLevel: 8, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.GreaterThanOrEqualTo, atLevel: 17, amount: 2, slotLevel: 8, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(comparator: Comparator.GreaterThanOrEqualTo, atLevel: 17, amount: 2, slotLevel: 9, ids: new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
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

        private Effect CreateSpellSlotEffect(Comparator comparator, int atLevel, int amount, int slotLevel, Guid[] ids)
        {
            return new GainSpecificSpellSlotEffect
            {
                Id = ids[0],
                Amount = amount,
                Level = slotLevel,
                IsSpendingPreventable = true,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding { Id = ids[1], Prerequisite = new HaveSpecificLevelPrerequisite { Id = ids[2], Comparator = comparator, RequiredLevel = atLevel} }
                }
            };
        }
    }
}
