using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MarinersCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("117860b5-a1af-46fc-80fb-26d7e2bc6fb1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mariner's Curse",
                Level = 5,
                Range = "Touch.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("960d497a-188d-4817-8905-bc6f1d61b21c"), Type = TextBlockType.Text, Text = "You afflict the target with the curse of the roiling, unforgiving sea. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("345724d0-1b40-44c3-82f1-894cfd8f3fbb"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target becomes sickened 1. Reducing its sickened condition to 0 ends the curse.",
                Failure = "The target becomes sickened 1 and can't reduce its sickened condition below 1 while the curse remains. The curse can be lifted by remove curse or similar magic. Whenever the target is sickened and on the water at least a mile from shore, it is also slowed 1.",
                CriticalFailure = "As failure, but the target becomes sickened 2."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("81318fde-55ed-45dd-8de9-74b9d2c8eefc"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("8f494d59-03e3-4266-b151-4f86366e8b77"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09273f7b-9f3b-4206-bc5e-3aa3108c812b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 350
            };
        }
    }
}
