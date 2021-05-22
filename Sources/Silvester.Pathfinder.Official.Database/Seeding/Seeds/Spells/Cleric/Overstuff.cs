using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Overstuff : Template
    {
        public static readonly Guid ID = Guid.Parse("ed10a7d4-1078-4d14-af96-b4ed9a03a5ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Overstuff",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                DomainId = Domains.Instances.Indulgence.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b306b8c5-a272-4278-b7c8-bfa40c406882"), Type = TextBlockType.Text, Text = "Huge amounts of food and drink fill the target. It receives a full meal’s worth of nourishment and must attempt a Fortitude save." };
            yield return new TextBlock { Id = Guid.Parse("bf085581-8105-4736-ac8a-42b8a99ca37c"), Type = TextBlockType.Text, Text = "A target sickened by this spell takes a –10-foot status penalty to its Speed until it’s no longer sickened." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6a254fa3-badb-4315-88c6-32ba3e737bc9"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is sickened 1, but if it spends an action to end the condition, it succeeds automatically.",
                Failure = "The target is sickened 1.",
                CriticalFailure = "The target is sickened 2."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cleric.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c643441e-76a3-41aa-8cb4-88ad0152e8af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 394
            };
        }
    }
}
