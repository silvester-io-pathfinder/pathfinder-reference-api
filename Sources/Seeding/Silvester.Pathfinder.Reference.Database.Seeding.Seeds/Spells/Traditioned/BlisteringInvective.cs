using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlisteringInvective : Template
    {
        public static readonly Guid ID = Guid.Parse("9ad5da73-93c5-4435-9cae-ad6c62ddccf9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blistering Invective",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fa8a077-7f07-431d-9b97-291c8fe326e5"), Type = TextBlockType.Text, Text = "A heap of insults and invectives spew from your mouth— words so devastating your foes burn from the intensity of your diatribe. Your words deal 2d6 persistent fire damage, and the target must attempt a Will save. If the target doesn't understand the language or you're not speaking a language, it gains a +4 circumstance bonus to its save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7cd54fd2-4749-4515-acc6-3cd1e4c4a70b"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0be13aa7-2547-450d-b29a-791da6c77733"), Type = TextBlockType.Text, Text = "You can target two additional creatures, and the persistent damage increases by 2d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("498c833f-4067-49b1-92f5-efdaf10c41fa"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes half the persistent fire damage.",
                Failure = "The target becomes frightened 1 and takes the full persistent fire damage.",
                CriticalFailure = "The target becomes frightened 2 and takes double the persistent fire damage."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("9c0a171a-5c43-49f6-bcea-dc268c704daa"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("c36c85c2-2f6b-4d70-89b7-7ddacf4af255"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("90818098-8a2f-406b-978d-4c6233d69c98"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("3b058b17-f783-47dc-8280-cb90e5cbede4"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("7a929eac-608b-4718-9407-e4b2c8081872"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b75cf0d9-94e6-41d7-bbc0-c66a9caf0601"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 216
            };
        }
    }
}
