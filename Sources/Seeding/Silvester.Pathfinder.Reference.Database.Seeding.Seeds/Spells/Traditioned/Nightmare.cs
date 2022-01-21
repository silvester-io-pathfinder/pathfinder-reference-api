using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Nightmare : Template
    {
        public static readonly Guid ID = Guid.Parse("083d1186-7e18-46d7-81c1-baceb222ef4b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nightmare",
                Level = 4,
                CastTime = "10 minutes.",
                Range = "Planetary.",
                Duration = "1 day.",
                Targets = "1 creature you know by name.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03e05465-b49e-4c91-a757-94d1dc286716"), Type = TextBlockType.Text, Text = "You send disturbing nightmares to your target. The next time the target falls asleep, it must attempt a Will save. If you know the target only by name and have never met them, the target gets a +4 circumstance bonus to the Will save." };
        }
        
        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("55a57c6f-b102-46fd-a986-cd5ce3e32a7c"),
                CriticalSuccess = "The target suffers no adverse effects and is temporarily immune for 1 week.",
                Success = "The target experiences the nightmares but suffers no adverse effects other than unpleasant memories.",
                Failure = "The target experiences the nightmares and awakens fatigued.",
                CriticalFailure = "The target experiences the nightmares, awakens fatigued, and is drained 2 until it is no longer fatigued."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
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
            builder.Add(Guid.Parse("ad714416-0332-4ad0-b476-4c6bb1a70b6f"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("001a5df4-c453-4967-9054-e756600b5bbe"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("950ed4f2-8f5b-43a4-b391-c82ce1fda5a3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 354
            };
        }
    }
}
