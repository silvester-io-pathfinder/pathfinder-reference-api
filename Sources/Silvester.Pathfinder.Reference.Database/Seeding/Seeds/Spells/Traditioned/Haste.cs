using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Haste : Template
    {
        public static readonly Guid ID = Guid.Parse("00ef5f27-7761-4b7e-a158-f7ef102eb585");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Haste",
                Level = 3,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2a67324-858d-44e7-a6b8-cf5c8a3548e3"), Type = TextBlockType.Text, Text = "Magic empowers the target to act faster. It gains the quickened condition and can use the extra action each round only for Strike and Stride actions." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ef4e6ef0-301a-4447-bc20-3dfd8fc69e1c"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("375aeafe-a037-4482-9f3c-450263efce64"), Type = TextBlockType.Text, Text = "You can target up to 6 creatures." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13aafdf6-b4f8-4365-a8a8-2343fa8b4524"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 343
            };
        }
    }
}
