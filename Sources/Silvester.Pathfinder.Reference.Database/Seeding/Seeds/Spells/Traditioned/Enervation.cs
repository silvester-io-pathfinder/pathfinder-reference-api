using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Enervation : Template
    {
        public static readonly Guid ID = Guid.Parse("d63d0e3a-03d7-4cd1-9aea-b47a2b61ad77");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enervation",
                Level = 4,
                Area = "30-foot line.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3f0732b8-53f2-4a7e-96ac-a327e42d8026"), Type = TextBlockType.Text, Text = "Extending a finger, you fire a beam of negative energy that weakens the life force of any creature it touches. Each living creature in the line must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("718c48c4-fbaa-43ab-8613-1b4fb2dbfdf1"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("09293ea8-6fe8-4a43-bb7e-f2e335c59405"), Type = TextBlockType.Text, Text = "The persistent negative damage increases by 1d8 on a success, or by 2d8 on a failure or critical failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("29119fe4-5510-438e-892b-e0a354fbbb03"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes 2d8 persistent negative damage.",
                Failure = "The creature takes 4d8 persistent negative damage and becomes drained 1.",
                CriticalFailure = "The creature takes 4d8 persistent negative damage and becomes drained 2 and doomed 1."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bd8e532-9cdd-4082-ac01-d9e51ff498b2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 218
            };
        }
    }
}
