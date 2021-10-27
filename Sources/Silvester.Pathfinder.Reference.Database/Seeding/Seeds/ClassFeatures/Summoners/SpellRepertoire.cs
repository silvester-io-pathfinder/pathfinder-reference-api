using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The collection of spells you can cast is called your spell repertoire. At 1st level, you learn two 1st-level spells of your choice and five cantrips of your choice. You choose these from the common spells from the tradition corresponding to your eidolon, or from other spells from that tradition to which you have access. You can cast any spell in your spell repertoire by using a spell slot of an appropriate spell level. Your spell slots and the spells in your spell repertoire are separate. If a feat or other ability adds a spell to your spell repertoire, it doesn't give you another spell slot, and vice versa" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You add to this spell repertoire as you increase in level. Each time you get a spell slot (see Table 2–4: Summoner Spells per Day), you add a spell of the same level to your spell repertoire. At 2nd level, you select another 1st-level spell. At 3rd level, you add the first 2nd-level spell to your repertoire. At 4th level you gain your second and your spell repertoire reaches its maximum size of five spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 5th level, in addition to adding two 3rd-level spells to your repertoire, you lose your lowest level of spell slots. Any time you lose a level of spell slots, you lose two spells in your repertoire as well. These can come from spells you already know or out of the number of new spells you're learning. On levels in which you don't change your spell slots, you can swap out multiple spells, as described below." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Heading, Text = "Swapping Spells In Your Repertoire" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As you gain new spells in your repertoire, you might want to replace some of the spells you previously learned. Each time you gain a level and learn new spells, you can swap out one of your old spells for a different spell of the same level. If it's a level at which you lose a set of lower-level slots, you can replace the two in either order. You can also instead swap a cantrip. You can also swap out spells by retraining during downtime." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 6th level and every even level thereafter, you can swap out any number of your spells for different spells of a level you can cast. When you do, you must keep at least one spell you can cast with your lowest level of spell slots so you don't end up with slots you can't use. For instance, at 6th level you would need to keep at least one 2nd-level spell, but all your other spells could be 3rd level." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //Five cantrips.
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 0);
            builder.GainAnySpell(Guid.Parse(""), spellLevel: 0);

            //Two first level spells.
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 1);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 1, requiredLevel: 1);

            //Gain a spell any time you gain a spell slot (excluding the second level 1 spell slot).
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 3);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 4);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 2, requiredLevel: 4);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 3, requiredLevel: 5);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 4, requiredLevel: 7);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 5, requiredLevel: 9);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 6, requiredLevel: 11);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 7, requiredLevel: 13);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 8, requiredLevel: 15);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 17);
            builder.GainAnySpell(Guid.Parse(""), Guid.Parse(""), spellLevel: 9, requiredLevel: 17);

            //Lose a spell any time you lose a spell slot.
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 5);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 7);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 9);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 11);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 13);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 15);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17);
            builder.LoseAnySpell(Guid.Parse(""), Guid.Parse(""), requiredLevel: 17);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 55
            };
        }
    }
}
