using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SealFate : Template
    {
        public static readonly Guid ID = Guid.Parse("c7f662a7-c1ae-42dd-b213-909077f87f5d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Seal Fate",
                Level = 4,
                Range = "Touch.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b8c87372-0ec1-4724-9863-c697a6376a34"), Type = TextBlockType.Text, Text = "You utter a curse that a creature will meet a certain end—a death by freezing, stabbing, or another means you devise. Choose one type of damage from the following list: acid, bludgeoning, cold, electricity, fire, negative, piercing, slashing, or sonic. The effect is based on the target's Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("76bd1f11-f815-4853-852b-6bcee67f538d"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("bc6c9a6c-8143-4955-9ca0-567551974c61"), Type = TextBlockType.Text, Text = "The weakness increases by 1, and the maximum level of creature that can be automatically killed increases by 4." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("fc94608c-6b9b-4ea8-9bf4-8cc5e6e0014a"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target gains weakness 2 to the chosen damage type until the end of your next turn.",
                Failure = "As success, but the duration is 1 minute. If the creature is reduced to 0 HP by the chosen damage and its level is 7 or less, it dies.",
                CriticalFailure = "As failure, but the duration is unlimited."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1b5d759b-5c3a-4a94-812a-0e5f1d344bb0"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("1b7a8360-cc0f-47c5-86e1-228b454fdf1b"), Traits.Instances.Death.ID);
            builder.Add(Guid.Parse("1d98a443-0d9e-4eef-8300-d719137f17c8"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51a8d792-b41b-49f0-97fa-a968032c30b7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 224
            };
        }
    }
}
