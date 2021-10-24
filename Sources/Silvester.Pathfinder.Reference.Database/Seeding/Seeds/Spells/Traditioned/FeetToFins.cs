using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FeetToFins : Template
    {
        public static readonly Guid ID = Guid.Parse("dbcc2afe-172f-4a67-bfb1-1db59d4c94f7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Feet to Fins",
                Level = 3,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd2e07d5-5c99-4934-9033-c4208643cc14"), Type = TextBlockType.Text, Text = "The target’s feet transform into fins, improving mobility in the water but reducing it on land. The target gains a swim Speed equal to its normal land Speed, but its land Speed becomes 5 feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("13e070af-bc40-4d7b-8482-a710a703587d"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("54597a67-332f-4ebc-8ef7-5f0814267582"), Type = TextBlockType.Text, Text = "The spell lasts until the next time you make your daily preparations." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38671e75-eb26-4d19-9f64-cdfafa51ad49"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 337
            };
        }
    }
}
