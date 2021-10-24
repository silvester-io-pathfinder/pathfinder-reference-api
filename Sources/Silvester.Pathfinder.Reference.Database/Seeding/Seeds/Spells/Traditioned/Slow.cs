using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Slow : Template
    {
        public static readonly Guid ID = Guid.Parse("5f8ef3e1-99e9-44c8-b043-c4fa50c98b4e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Slow",
                Level = 3,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cf9c516-07ed-46e1-b5d4-14c2e9a29e20"), Type = TextBlockType.Text, Text = "You dilate the flow of time around the target, slowing its actions." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("63d4e458-959c-4785-b697-64f4d334906e"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("4a240c5a-650d-4260-b5fb-c3e849df06f8"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2f914f80-bb1e-40fa-babd-95dc1b8d7a52"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is slowed 1 for 1 round.",
                Failure = "The target is slowed 1 for 1 minute.",
                CriticalFailure = "The target is slowed 2 for 1 minute."
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
            yield return Traits.Instances.Polymorph.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6c90d4d-46ab-4152-9e9b-cfaac0d2b16c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
