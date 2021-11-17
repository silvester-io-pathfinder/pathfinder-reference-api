using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class IllOmen : Template
    {
        public static readonly Guid ID = Guid.Parse("6e6315c3-5c27-44a5-9127-fad940826632");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ill Omen",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("63daedcb-712b-4430-b5f6-e7a3dc399bfb"), Type = TextBlockType.Text, Text = "The target is struck with misfortune, which throws it off balance. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d4c1badc-b7e8-45d8-beb4-c63d1386406f"),
                Success = "The target is unaffected.",
                Failure = "The first time during the duration that the target attempts an attack roll or skill check, it must roll twice and use the worse result.",
                CriticalFailure = "Every time during the duration that the target attempts an attack roll or skill check, it must roll twice and use the worse result."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Misfortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d08762ff-1682-45e5-bb6d-e62861b1d55f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 221
            };
        }
    }
}
