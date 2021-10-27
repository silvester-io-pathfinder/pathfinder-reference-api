using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and four cantrips of your choice, as well as an additional spell and cantrip from your bloodline. You choose these from the common spells from the tradition corresponding to your bloodline, or from other spells from that tradition to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 3–17), you add a spell of the same level to your spell repertoire. When you gain access to a new level of spells, your first new spell is always the spell granted by your bloodline, but you can choose the other spells. At 2nd level, you select another 1st-level spell; at 3rd level, you gain a new spell from your bloodline and two other 2nd-level spells, and so on. When you add spells, you might select a higher-level version of a spell you already know so that you can cast a heightened version of that spell." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Though you gain them at the same rate, your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it wouldn't give you another spell slot, and vice versa." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Swapping Spells In Your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you gain new spells in your spell repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. This spell can be a cantrip, but you can't swap out bloodline spells. You can also swap out spells by retraining during downtime." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 2);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 4);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 6);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 8);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 10);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 12);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 14);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 16);

            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 192
            };
        }
    }
}
