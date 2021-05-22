using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FungalInfestation : Template
    {
        public static readonly Guid ID = Guid.Parse("4d55fa92-d467-461b-9788-2b0d9e803677");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Fungal Infestation",
                Level = 2,
                Range = "Touch.",
                Area = "15-foot cone.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e3181cf-329d-4065-a054-76523c9db66f"), Type = TextBlockType.Text, Text = "Toxic spores swarm over creatures in the area, causing them to erupt in grotesque fungal growths. These noxious growths deal 2d6 persistent poison damage, and each creature must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d83e9607-4345-4e31-9dd1-b1373db3f8f1"), 
                Level = "+2",
                Details =
                {
                   new TextBlock { Id = Guid.Parse("9cfd60aa-760f-4b75-b727-7c261160dd19"), Type = TextBlockType.Text, Text = "The persistent damage increases by 2d6, and the weakness increases by 1, or by 2 on a critical failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1e7d9528-0419-4cb9-8b8f-3035fa188cd6"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The target takes half the persistent poison damage.",
                Failure = "The target takes the full persistent poison damage. While it is taking this persistent poison damage, it has weakness 1 to fire and weakness 1 to slashing.",
                CriticalFailure = "As failure, but double the persistent poison damage. While it is taking this persistent poison damage, it has weakness 2 to fire and weakness 2 to slashing."
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
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa2e3115-9633-4859-89b6-9e14954ab4f5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 220
            };
        }
    }
}
