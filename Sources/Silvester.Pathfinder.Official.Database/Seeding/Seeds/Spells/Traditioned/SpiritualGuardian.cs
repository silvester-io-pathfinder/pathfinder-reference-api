using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritualGuardian : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spiritual Guardian",
                Level = 5,
                Range = "120 feet.",
                IsDismissable = true,
                Requirements = "You have a deity.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A Medium guardian made of magical force appears and attacks foes you designate within range. The spiritual guardian is translucent and appears to be holding your deity’s favored weapon." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you Cast the Spell, the spiritual guardian appears in an unoccupied space next to a foe of your choice within range and makes a Strike against it. Each time you Sustain the Spell, you can move the spiritual guardian to an unoccupied space next to a target within range (if necessary) and make a Strike with it. The guardian uses and contributes to your multiple attack penalty. Alternatively, when you Sustain the Spell, you can have the guardian move adjacent to an ally and protect that ally. If you do, each time the ally would take damage, the guardian takes the first 10 damage instead of your ally. It continues to do so until you move the guardian to attack an enemy or defend a different ally, or until the guardian is destroyed (it has 50 Hit Points and can’t recover Hit Points by any means). The guardian can’t usually take damage except when protecting an ally, though disintegrate automatically destroys it if it hits the spiritual guardian’s AC of 25." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The guardian’s Strikes are melee spell attacks. Regardless of the appearance of the guardian’s weapon, the guardian deals force damage equal to 2d8 plus your spellcasting ability modifier, but you can deal damage of the type normally dealt by the weapon it holds instead of force damage. No other traits or statistics of the weapon apply, and even a ranged weapon attacks adjacent creatures only. Despite making a spell attack, the spiritual guardian’s weapon is a weapon for the purposes of triggers, resistances, and so forth." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The guardian takes up space and allies can use it when flanking, but it doesn’t have any other attributes a creature would normally have aside from Hit Points, and creatures can move through its space without hindrance. The guardian can’t make any attack other than its Strike, and feats or spells that affect weapons or enhance allies do not apply to the guardian." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The guardian’s damage increases by 1d8, and its Hit Points increase by 20." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Force.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 373
            };
        }
    }
}
