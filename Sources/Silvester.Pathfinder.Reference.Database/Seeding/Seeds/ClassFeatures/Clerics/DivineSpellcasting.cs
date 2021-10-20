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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class DivineSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your deity bestows on you the power to cast divine spells. You can cast divine spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a cleric, you can usually hold a divine focus (such as a religious symbol) for spells requiring material components instead of needing to use a material component pouch. At 1st level, you can prepare two 1st-level spells and five cantrips each morning from the common spells on the divine spell list in this book or from other divine spells to which you gain access. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a cleric, the number of spells you can prepare each day increases, as does the highest level of spell you can cast, as shown in Table 3–9: Cleric Spells per Day on page 120." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or your enemies to roll against your spell DC (typically by attempting a saving throw). Since your key ability is Wisdom, your spell attack rolls and spell DCs use your Wisdom modifier." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is always automatically heightened to half your level rounded up—this is usually equal to the highest level of cleric spell slot you have. For example, as a 1st-level cleric, your cantrips are 1st-level spells, and as a 5th-level cleric, your cantrips are 3rd-level spells." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSpellCastingEffect
            {
                Id = Guid.Parse(""),
                MagicTraditionId = MagicTraditions.Instances.Divine.ID
            };

            //Cantrips.
            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 5,
                Level = 0,
                IsSpendingPreventable = true
            };

            //Regular spell slots.
            yield return CreateSpellSlotEffect(requiredLevel: 1,  spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2,  ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 3,  spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4,  ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 5,  spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6,  ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 7,  spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8,  ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 9,  spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10, ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12, ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14, ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16, ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18, ids: new [] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            //Divine font spell slots. These are prerequisited to be active only at their specific levels.
            yield return CreateDivineFontSpellSlots(requiredLevel: 1,  spellSlotLevel: 1,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 2,  spellSlotLevel: 1,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 3,  spellSlotLevel: 2,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 4,  spellSlotLevel: 2,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 5,  spellSlotLevel: 3,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 6,  spellSlotLevel: 3,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 7,  spellSlotLevel: 4,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 8,  spellSlotLevel: 4,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 9,  spellSlotLevel: 5,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 10, spellSlotLevel: 5,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 11, spellSlotLevel: 6,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 12, spellSlotLevel: 6,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 13, spellSlotLevel: 7,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 14, spellSlotLevel: 7,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 15, spellSlotLevel: 8,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 16, spellSlotLevel: 8,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 17, spellSlotLevel: 9,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 18, spellSlotLevel: 9,  new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 19, spellSlotLevel: 10, new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateDivineFontSpellSlots(requiredLevel: 20, spellSlotLevel: 10, new[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 118
            };
        }

        private Effect CreateSpellSlotEffect(int requiredLevel, int spellSlotLevel, int amount, int increaseTo, int atLevel, Guid[] ids)
        {
            return new GainSpecificSpellSlotEffect
            {
                Id = ids[0],
                Amount = amount,
                Level = spellSlotLevel,
                IsSpendingPreventable = true,
                Prerequisites = new EffectPrerequisiteBinding[]
                {
                    new EffectPrerequisiteBinding { Id = ids[1], Prerequisite = new HaveSpecificLevelPrerequisite { Id = ids[2], Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = requiredLevel} }
                },
                Increments = new[]
                {
                    new IncreaseAmountToIncrement { Id = ids[3], Amount = increaseTo, Trigger = new LevelTrigger { Id = ids[4], Level = atLevel }}
                }
            };
        }

        private Effect CreateDivineFontSpellSlots(int requiredLevel, int spellSlotLevel, Guid[] ids)
        {
            return new GainDivineFontSpellSlotEffect
            {
                Id = ids[0],
                Level = spellSlotLevel,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding { Id = ids[1], Prerequisite = new HaveSpecificLevelPrerequisite { Id = ids[2], Comparator = Comparator.EqualTo, RequiredLevel = requiredLevel} }
                }
            };
        }
    }
}
