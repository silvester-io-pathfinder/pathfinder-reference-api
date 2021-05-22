using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UnfetteredPack : Template
    {
        public static readonly Guid ID = Guid.Parse("b5ab8638-f6c4-454e-9c77-2ae94bd1898b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unfettered Pack",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 hour.",
                Targets = "Up to 10 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5ab8638-f6c4-454e-9c77-2ae94bd1898b"), Type = TextBlockType.Text, Text = "You free those who travel alongside you from environmental hindrances. Targets don’t take circumstance penalties to Speed from vegetation, rubble, winds, or other properties of the environment, whether or not the environment is magical, and they ignore difficult terrain from such environmental properties." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b5ab8638-f6c4-454e-9c77-2ae94bd1898b"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b5ab8638-f6c4-454e-9c77-2ae94bd1898b"), Type = TextBlockType.Text, Text = "The targets also ignore greater difficult terrain from environmental properties." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5ab8638-f6c4-454e-9c77-2ae94bd1898b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
