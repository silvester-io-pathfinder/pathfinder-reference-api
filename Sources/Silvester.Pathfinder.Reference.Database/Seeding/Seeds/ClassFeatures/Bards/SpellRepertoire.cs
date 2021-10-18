using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class SpellRepertoire : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Spell Repertoire", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level occult spells of your choice and five occult cantrips of your choice. You choose these from the common spells from the occult list or from other occult spells to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 3–6), you add a spell to your spell repertoire of the same level. At 2nd level, you select another 1st-level spell; at 3rd level, you select two 2nd-level spells, and so on. When you add spells, you might add a higher-level version of a spell you already have, so you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 1, MagicTraditionId = MagicTraditions.Instances.Occult.ID };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 1, MagicTraditionId = MagicTraditions.Instances.Occult.ID };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 1, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 2 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 2, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 2, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 3 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 2, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 4 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 3, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 5 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 3, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 5 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 3, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 6 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 4, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 4, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 7 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 4, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 8 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 5, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 9 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 5, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 9 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 5, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 10 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 6, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 6, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 11 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 6, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 12 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 7, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 7, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 13 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 7, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 14 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 8, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 8, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 15 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 8, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 16 } } } };

            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 9, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 17 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 9, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 17 } } } };
            yield return new GainAnySpellEffect { Id = Guid.Parse(""), Level = 9, MagicTraditionId = MagicTraditions.Instances.Occult.ID, Prerequisites = new[] { new EffectPrerequisiteBinding { Id = Guid.Parse(""), Prerequisite = new HaveSpecificLevelPrerequisite { Id = Guid.Parse(""), Comparator = Comparator.GreaterThanOrEqualTo, RequiredLevel = 18 } } } };
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
    }
}
