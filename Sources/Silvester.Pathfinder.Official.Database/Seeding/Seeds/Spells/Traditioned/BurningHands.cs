using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class BurningHands : Template
    {
        public static readonly Guid ID = Guid.Parse("ea3e3b79-80ab-4ef4-9dc7-6fb38561a935");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Burning Hands",
                Level = 1,
                Area = "15-foot cone.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1158bbf7-f745-4c30-9a1f-d7833f60fda4"), Type = Utilities.Text.TextBlockType.Text, Text = "Gouts of flame rush from your hands. You deal 2d6 fire damage to creatures in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("0433232e-b381-4a6d-bd3c-404bfdedb535"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e40d5cb9-53ed-44ed-a996-e81ba3b76103"), Type = Utilities.Text.TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4dfc4e79-6a45-4cc2-8116-ccd821d75551"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 322
            };
        }
    }
}
