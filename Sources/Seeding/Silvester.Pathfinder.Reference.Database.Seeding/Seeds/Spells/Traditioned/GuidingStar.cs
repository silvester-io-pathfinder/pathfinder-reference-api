using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class GuidingStar : Template
    {
        public static readonly Guid ID = Guid.Parse("39dd0363-e065-4669-804b-67b0b62d3c5c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Guiding Star",
                Level = 2,
                Range = "Planetary.",
                Duration = "Until your next daily preparations.",
                Targets = "1 creature you've met.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26810895-b378-4a3b-a2ba-cdf3a0a90046"), Type = TextBlockType.Text, Text = "You call on the constellations of the night sky to guide a creature to the location where you Cast the Spell. Each time the target views the stars, it receives a mental nudge toward your chosen location, though it isn�t compelled to follow. The target can recognize you as the source. If the creature goes to another planet or plane, the spell�s effects are suppressed, but they resume if the creature returns." };
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
            yield return Traits.Instances.Detection.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fb4fa879-be52-440b-89bf-f82834cb5b8c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 109
            };
        }
    }
}