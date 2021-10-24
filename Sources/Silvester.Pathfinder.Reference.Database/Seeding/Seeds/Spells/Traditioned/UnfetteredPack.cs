using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnfetteredPack : Template
    {
        public static readonly Guid ID = Guid.Parse("828aa492-5c0a-4c77-8a3c-8bdb17a8f611");

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
            yield return new TextBlock { Id = Guid.Parse("8b675cff-cc03-4767-8ae8-0dd74c96c97f"), Type = TextBlockType.Text, Text = "You free those who travel alongside you from environmental hindrances. Targets don’t take circumstance penalties to Speed from vegetation, rubble, winds, or other properties of the environment, whether or not the environment is magical, and they ignore difficult terrain from such environmental properties." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2187fa27-57bb-45b1-97df-d0d54081817e"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("feb9f27f-89ef-4c4e-aa50-980104b5f3ff"), Type = TextBlockType.Text, Text = "The targets also ignore greater difficult terrain from environmental properties." }
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
                Id = Guid.Parse("93fdf887-e312-4985-806d-ab1518b1d8f9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 379
            };
        }
    }
}
