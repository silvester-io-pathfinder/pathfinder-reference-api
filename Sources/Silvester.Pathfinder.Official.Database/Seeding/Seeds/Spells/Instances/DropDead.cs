using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class DropDead : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Drop Dead",
                Level = 5,
                Range = "120 feet.",
                Duration = "Sustained up to 1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The target appears to fall down dead, though it actually turns invisible. Its illusory corpse remains where it fell, complete with a believable fatal wound. This illusion looks and feels like a dead body. If the target’s death seems absurd—for instance, a barbarian at full health appears to be slain by 2 damage—the GM can grant the attacker an immediate Perception check to disbelieve the illusion. If the target uses hostile actions, the spell ends. This ends the entire spell, so the illusory corpse disappears too." };
        }

        public override IEnumerable<SpellTrigger> GetTriggers()
        {
            yield return new SpellTrigger
            {
                Id = Guid.Parse(""),
                Text = "A creature within range is hit by an attack from an enemy.",
            };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "tth",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The spell doesn’t end if the target uses hostile actions." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 333
            };
        }
    }
}
