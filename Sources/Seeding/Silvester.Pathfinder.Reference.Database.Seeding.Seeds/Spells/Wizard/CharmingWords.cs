using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("d50755a9-dee2-4926-9207-35dbd6a635aa"), Type = TextBlockType.Text, Text = "You whisper enchanting words to deflect your foe's ire. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4d9bf000-8786-44e4-b628-9b3ce4de498d"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a –1 circumstance penalty to attack rolls and damage rolls against you.",
                Failure = "The target can't use hostile actions against you.",
                CriticalFailure = "The target is stunned 1 and can't use hostile actions against you."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b8ad5650-6252-433e-bd3c-a610e5b12774"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("efb622ed-440c-4e82-b200-802b350d8176"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("9c3c161e-3608-4b40-b12d-c2a9b8eb8dcc"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("151fb4a7-7703-42e1-a17a-b37c18c9020b"), Traits.Instances.Incapacitation.ID);
            builder.Add(Guid.Parse("61aa447f-5cf8-4030-868d-baa10a7f0020"), Traits.Instances.Linguistic.ID);
            builder.Add(Guid.Parse("ca6ef444-9c8e-4c8f-a40e-59be298eb85f"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("d3144f2e-9819-487b-b0b8-ce070423f454"), Traits.Instances.Wizard.ID);
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
