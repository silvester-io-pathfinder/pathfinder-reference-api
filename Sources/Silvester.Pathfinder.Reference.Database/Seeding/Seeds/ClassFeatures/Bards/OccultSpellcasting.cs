using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class OccultSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Occult Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You draw upon magic from esoteric knowledge. You can cast occult spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a bard, you can usually play an instrument for spells requiring somatic or material components, as long as it takes at least one of your hands to do so. If you use an instrument, you don't need a material component pouch or another hand free. You can usually also play an instrument for spells requiring verbal components, instead of speaking." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each day, you can cast up to two 1st-level spells. You must know spells to cast them, and you learn them via the spell repertoire class feature. The number of spells you can cast each day is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you increase in level as a bard, your number of spells per day increases, as does the highest level of spells you can cast." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Charisma, your spell attack rolls and spell DCs use your Charisma modifier. Details on calculating these statistics are found under Spell Attack Rolls." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSpellCastingEffect
            {
                Id = Guid.Parse(""),
                MagicTraditionId = MagicTraditions.Instances.Occult.ID
            };

            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 5,
                Level = 0,
                IsSpendingPreventable = true
            };

            yield return CreateSpellSlotEffect(requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpellSlotEffect(requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 96
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
                    new EffectPrerequisiteBinding { Id = ids[1], Prerequisite = new HaveSpecificLevelPrerequisite { Id = ids[2], Comparator = Comparator.GreaterThanOrEqualTo,RequiredLevel = requiredLevel} }
                },
                Increments = new[]
                {
                    new IncreaseAmountToIncrement { Id = ids[3], Amount = increaseTo, Trigger = new LevelTrigger { Id = ids[4], Level = atLevel }}
                }
            };
        }
    }
}
