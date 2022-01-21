using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TouchOfIdiocy : Template
    {
        public static readonly Guid ID = Guid.Parse("9374514e-bdad-4483-9123-7267445ba464");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Touch of Idiocy",
                Level = 2,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5cdbf67b-48c5-4758-9a31-57a7ca0e485b"), Type = TextBlockType.Text, Text = "You dull the target's mind; the target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("9488d8e8-b090-4ceb-8453-83f832e73374"),
                Success = "The target is unaffected.",
                Failure = "The target is stupefied 2.",
                CriticalFailure = "The target is stupefied 4."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("618849b2-f9ab-4e97-9385-6100a35a0b43"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("db0635b2-905d-4fdc-b234-67a56bc2de92"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a25e7d09-e889-4cef-8831-7974b568f81f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
