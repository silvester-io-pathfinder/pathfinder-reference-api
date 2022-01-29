using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DaydreamersCurse : Template
    {
        public static readonly Guid ID = Guid.Parse("85f7e8dd-4e97-4e9c-8872-f1c11dbf1141");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Daydreamer's Curse",
                Level = 4,
                Range = "Touch.",
                Targets = "1 creature.",
                Duration = "Varies.",
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("924b60a6-4c11-41fc-bf1f-cf2b4bbc2567"), Type = TextBlockType.Text, Text = "You impose a curse upon the target that renders it easily distracted and unable to focus its thoughts on tasks that demand insight or discernment. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("c2e7f17f-1fb3-444e-b000-374e159d1816"),
                CriticalSuccess = "The target is unaffected.",
                Success = "For 10 minutes, the target must roll twice and use the worse result whenever attempting a Medicine, Nature, Perception, or Survival check. If the target critically succeeds at a Perception check or skill check to perform an action with the concentrate trait, the target gets a success instead.",
                Failure = "As success, but the effect is permanent.",
                CriticalFailure = "As failure, except the target treats the outcomes of all checks with the concentrate trait as one degree of success worse than the result it rolled (a critical success becomes a success, a success becomes a failure, and a failure becomes a critical failure)."
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
            builder.Add(Guid.Parse("a3a93a5e-3bc8-4361-ad96-1ac77ad97c20"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("7edaa23e-acc3-4797-826a-0b201a808f9e"), Traits.Instances.Attack.ID);
            builder.Add(Guid.Parse("20e3a731-b3fd-4a8b-b536-cd2bf97a2001"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("37e3da6d-4878-4513-aa9e-bd5444594d70"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("299c535f-d946-4cbd-8c19-f92ff3b9aa5e"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("4c3a7175-fa1e-4691-a5dc-3f4d079da118"), Traits.Instances.Misfortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec53ebec-ccb9-4648-a1e6-bf8b660f30a7"),
                SourceId = Sources.Instances.Pathfinder164.ID,
                Page = 73
            };
        }
    }
}
