using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicAura : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Aura",
                Level = 1,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "Until the next time you make your daily preparations.",
                Targets = "1 object of 3 bulk or less.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You alter the appearance of an item’s magic aura. You can choose to have the target’s aura appear as that of a common magic item of twice magic aura’s level or lower, or to have it register as being under the effects of a spell of your choice of magic aura’s level or lower. If the target is magical, you can instead choose to have it appear as entirely non-magical." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "A caster using detect magic or read aura of an equal or higher spell level can attempt to disbelieve the illusion from magic aura. Magic aura doesn’t mask the aura of spells that are 9th level or higher or of items that are 19th level or higher." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can target a creature instead of an object. When you do, you can either conceal the auras of all magic items it has or have that creature’s aura appear as if it were under the effect of a spell you know." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 349
            };
        }
    }
}
