using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ClairaudienceSpellSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("484d98ad-91d1-4b2d-86d0-ec997a6f772b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Clairaudience",
                Level = 3,
                Range = 500,
                CastTime = TimeSpan.FromMinutes(1),
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("904c4278-3e9a-4846-8443-0b3aa0717974"), Type = Utilities.Text.TextBlockType.Text, Text = "You create an invisible floating ear at a location within range (even if it’s outside your line of sight or line of effect). It can’t move, but you can hear through the ear as if using your normal auditory senses." };
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
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Scrying.ID;
        }
    }
}
