using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AbyssalPlague : Template
    {
        public static readonly Guid ID = Guid.Parse("328dda55-0bc8-461f-a3d3-686df512438c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Abyssal Plague",
                Level = 5,
                Range = "Touch.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3c3fea0-9363-4659-a888-2196a2e88b29"), Type = Utilities.Text.TextBlockType.Text, Text = "Your touch afflicts the target with Abyssal plague, which siphons fragments of their soul away to empower the Abyss. The effect is based on the target's Fortitude save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("0450af9d-7660-403b-8970-5515635a7779"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes 2 evil damage per spell level, and takes a –2 status penalty to saves against Abyssal plague for 1 day or until the target contracts it, whichever comes first.",
                Failure = "The target is afflicted with Abyssal plague at stage 1.",
                CriticalFailure = "The target is afflicted with Abyssal plague at stage 2."
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("dade5dbe-d8ad-424c-b4c9-5beb8bc3fcb6"),
                DifficultyCheck = 25,
                Name = "Abyssal Plague",
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "2 days.",
                Onset = "Immediate.",
                Level = 9,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("2c4bcd91-243b-4230-a5ef-5b7cc3e3b044"),
                        Duration = "1 day",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("1d17119e-9947-4bdf-98b4-99f005f96317"), ConditionId = Conditions.Instances.Drained.ID, Severity = 1}
                        }
                    },
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("6b2623cf-3edc-4929-9db8-ebad4323e2f1"),
                        Duration = "1 day",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("d61bc2a1-2b5f-4c5a-b295-43d1213dc57d"), ConditionId = Conditions.Instances.Drained.ID, Severity = 3}
                        }
                    }
                }
            };
        }


        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("8e2fc864-769d-43c9-92f4-c5e962797099"), Traits.Instances.Chaotic.ID);
            builder.Add(Guid.Parse("ab1db331-c782-4e76-ba62-2d853d6de930"), Traits.Instances.Disease.ID);
            builder.Add(Guid.Parse("2f5b6b3d-2749-49da-8a07-94e7b70b53f1"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("a36edb0d-ad5d-43ec-b865-5315f65f3b90"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4681143a-4b28-4d09-9755-c72a4f6e5a53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 316
            };
        }
    }
}
