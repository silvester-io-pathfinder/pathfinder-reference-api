using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CharmingWords : Template
    {
        public static readonly Guid ID = Guid.Parse("ae7b3742-f94d-46e5-9a3f-858748bdc91d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Charming Words",
                Level = 1,
                Range = "30 feet.",
                Duration = "Until the start of your next turn.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d50755a9-dee2-4926-9207-35dbd6a635aa"), Type = TextBlockType.Text, Text = "You whisper enchanting words to deflect your foe’s ire. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4d9bf000-8786-44e4-b628-9b3ce4de498d"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a –1 circumstance penalty to attack rolls and damage rolls against you.",
                Failure = "The target can’t use hostile actions against you.",
                CriticalFailure = "The target is stunned 1 and can’t use hostile actions against you."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4002db6a-0158-4fe3-bb52-deef15a24559"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 406
            };
        }
    }
}
