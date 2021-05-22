using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WindWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("17d93624-4a75-42e8-9d67-0c92145aa3fb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wind Walk",
                Level = 8,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "You and up to five creatures touched.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17d93624-4a75-42e8-9d67-0c92145aa3fb"), Type = TextBlockType.Text, Text = "When you cast this spell, each target transforms into a vaguely cloud-like form and is picked up by a wind moving in the direction of your choice. You can change the wind’s direction by using a single action, which has the concentrate trait. The wind carries the targets at a Speed of 20 miles per hour, but if any of the targets make an attack, Cast a Spell, come under attack, or otherwise enter encounter mode, the spell ends for all targets just after they roll initiative, and they drift gently to the ground." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17d93624-4a75-42e8-9d67-0c92145aa3fb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 385
            };
        }
    }
}
