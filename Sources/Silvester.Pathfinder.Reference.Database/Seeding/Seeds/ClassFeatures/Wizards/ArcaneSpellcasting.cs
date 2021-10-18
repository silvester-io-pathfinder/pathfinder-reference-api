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
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpellBookEffect
            {
                Id = Guid.Parse(""),
                CantripAmount = 10,
                SpellAmount = 5,
                AddSpellsPerLevel = 2
            };

            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 5,
                Level = 0,
                IsSpendingPreventable = true
            };

            yield return new GainSpecificSpellSlotEffect
            {
                Id = Guid.Parse(""),
                Amount = 1,
                Level = 0,
                IsSpendingPreventable = true,
                Prerequisites = new[] 
                {
                    new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveAnyMagicSchoolPrerequisite { Id = Guid.Parse("") } }
                }
            };

            yield return CreateSpellSlotEffect(requiredLevel: 1, spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 1, spellSlotLevel: 1, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 3, spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 3, spellSlotLevel: 2, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 5, spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 5, spellSlotLevel: 3, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 7, spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 7, spellSlotLevel: 4, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 9, spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 9, spellSlotLevel: 5, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 11, spellSlotLevel: 6, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 13, spellSlotLevel: 7, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 15, spellSlotLevel: 8, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });

            yield return CreateSpellSlotEffect(requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18, ids: new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
            yield return CreateSpecialistSpellSlotEffect(requiredLevel: 17, spellSlotLevel: 9, new Guid[] { Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse(""), Guid.Parse("") });
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

        private Effect CreateSpecialistSpellSlotEffect(int requiredLevel, int spellSlotLevel, Guid[] ids)
        {
            return new GainSpecificSpellSlotEffect
            {
                Id = ids[0],
                Amount = 1,
                Level = spellSlotLevel,
                IsSpendingPreventable = true,
                Prerequisites = new[]
                {
                    new EffectPrerequisiteBinding { Id = ids[1], Prerequisite = new HaveSpecificLevelPrerequisite { Id = ids[2], Comparator = Comparator.GreaterThanOrEqualTo,RequiredLevel = requiredLevel} },
                    new EffectPrerequisiteBinding { Id = ids[3], Prerequisite = new HaveAnyMagicSchoolPrerequisite { Id = ids[4] } }
                }
            };
        }
    }
}
