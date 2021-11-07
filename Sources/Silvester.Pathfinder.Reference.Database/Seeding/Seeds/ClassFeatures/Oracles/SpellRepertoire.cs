using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and five cantrips of your choice. You choose these from the common spells from the divine spell list, or from other divine spells to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 2–3), you add a spell of the same level to your spell repertoire. At 2nd level, you select another 1st-level spell; at 3rd level, you select two 2nd-level spells, and so on. When you add spells, you might add a higher-level version of a spell you already have, so you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Swapping Spells in your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you gain new spells in your repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. You can also instead swap a cantrip. You can also swap out spells by retraining during downtime." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 1);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 1, requiredLevel: 2);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 3);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 2, requiredLevel: 4);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 5);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 3, requiredLevel: 6);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 7);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 4, requiredLevel: 8);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 9);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 5, requiredLevel: 10);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 11);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 6, requiredLevel: 12);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 13);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 7, requiredLevel: 14);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 15);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 8, requiredLevel: 16);

            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 17);
            builder.GainSpecificMagicTraditionAnySpell(Guid.Parse(""), Guid.Parse(""), MagicTraditions.Instances.Divine.ID, spellLevel: 9, requiredLevel: 18);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 68
            };
        }
    }
}
