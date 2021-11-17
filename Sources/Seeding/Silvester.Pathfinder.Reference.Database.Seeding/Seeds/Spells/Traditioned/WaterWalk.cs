using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WaterWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("51ebdb5b-77c4-4039-94b3-1ff8f22cf63f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Water Walk",
                Level = 2,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("832f8f39-2be7-4702-8dd9-68b9375b4e2e"), Type = TextBlockType.Text, Text = "The target can walk on the surface of water and other liquids without falling through. It can go underwater if it wishes, but in that case it must Swim normally. This spell doesn’t grant the ability to breathe underwater." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c7ff1d88-1574-45d3-a73e-3e0ae9fd21ca"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("9fed9ca9-7989-4dc5-a8ad-abae1965ffa9"), Type = TextBlockType.Text, Text = "The spell’s range increases to 30 feet, the duration increases to 1 hour, and you can target up to 10 creatures." }
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
                Id = Guid.Parse("2c05ff53-67d2-4448-9013-d7fce6355ff4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 384
            };
        }
    }
}
