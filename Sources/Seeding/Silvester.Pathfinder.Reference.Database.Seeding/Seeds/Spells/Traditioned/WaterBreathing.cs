using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WaterBreathing : Template
    {
        public static readonly Guid ID = Guid.Parse("df05c559-44c5-4780-bbdd-ae3e8df0587a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Water Breathing",
                Level = 2,
                CastTime = "1 minute.",
                Range = "30 feet.",
                Duration = "1 hour.",
                Targets = "Up to 5 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a0e5bd38-57d0-42e0-86c8-7d68b169b205"), Type = TextBlockType.Text, Text = "The targets can breathe underwater." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a13005e6-6a74-4622-a690-026a3deb1b36"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bc9e51c3-84d3-4be6-ba96-f481c54e3e61"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("94a44df3-ef35-4d42-9329-b93c2f237d58"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e6b1e4db-75ec-4db5-abd9-c9d43a6239ae"), Type = TextBlockType.Text, Text = "The duration increases to until your next daily preparations." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4971667b-ec8f-4453-a06c-51bd42b2d7ad"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
