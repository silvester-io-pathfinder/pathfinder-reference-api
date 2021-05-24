using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Telepathy : Template
    {
        public static readonly Guid ID = Guid.Parse("b1337486-1102-44da-a9e7-77e592d51a6e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telepathy",
                Level = 4,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4d88183d-1a85-4305-9b64-352e6d634806"), Type = TextBlockType.Text, Text = "You can communicate telepathically with creatures within 30 feet. Once you establish a connection by communicating with a creature, the communication is two-way. You can communicate only with creatures that share a language with you." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0b2d4acd-16ef-43ff-934b-2e9d535ab2e4"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2f42892f-369e-46d4-a60d-eb819baf6061"), Type = TextBlockType.Text, Text = "Telepathy loses the linguistic trait. You can communicate telepathically with creatures using shared mental imagery even if you don’t share a language." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("16dde7eb-8868-4d5b-8970-131ecb16fa66"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
