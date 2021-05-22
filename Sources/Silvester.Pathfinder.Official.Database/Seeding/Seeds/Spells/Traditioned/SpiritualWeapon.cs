using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritualWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spiritual Weapon",
                Level = 2,
                Range = "120 feet.",
                Duration = "Sustained up to 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A weapon made of pure magical force materializes and attacks foes you designate within range. This weapon has a ghostly appearance and manifests as a club, a dagger, or your deity’s favored weapon." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When you cast the spell, the weapon appears next to a foe you choose within range and makes a Strike against it. Each time you Sustain the Spell, you can move the weapon to a new target within range (if needed) and Strike with it. The spiritual weapon uses and contributes to your multiple attack penalty." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The weapon’s Strikes are melee spell attacks. Regardlessof its appearance, the weapon deals force damage equal to 1d8 plus your spellcasting ability modifier. You can deal damage of the type normally dealt by the weapon instead of force damage (or any of the available damage types for a versatile weapon). No other statistics or traits of the weapon apply, and even a ranged weapon attacks adjacent creatures only. Despite making a spell attack, the spiritual weapon is a weapon for purposes of triggers, resistances, and so forth." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The weapon doesn’t take up space, grant flanking, or have any other attributes a creature would. The weapon can’t make any attack other than its Strike, and feats or spells that affect weapons do not apply to it." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The weapon’s damage increases by 1d8." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
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
