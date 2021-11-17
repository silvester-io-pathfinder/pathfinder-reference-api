using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    /*
    public class XXTemplate : Template
    {
        public static readonly Guid ID = Guid.Parse("27e1d69d-9ea2-452b-a4b4-c926c08c8d1b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "",
                Level = ,
                Range = "",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2376b8e1-5295-43d0-a7af-cabacd000a46"), Type = TextBlockType.Text, Text = "" };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("90d3ac05-0218-492b-ae7e-d9061f5e5eff"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("10ab6b8b-650a-4301-ae39-d67606d6c17b"), Type = TextBlockType.Text, Text = "" }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e71ca84b-b61c-4171-8962-00bb990a3c4d"),
                CriticalSuccess = "",
                Success = "",
                Failure = "",
                CriticalFailure = ""
            };
        }

        protected override StaggeredEffect? GetStaggeredEffect()
        {
            return new StaggeredEffect
            {
                Id = Guid.Parse("ed7f0ab3-9dfb-4cea-8128-768714889e60"),
                DifficultyCheck = ,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                MaximumDuration = "2 days.",
                Onset = "",
                Level = 9,
                Stages =
                {
                    new StaggeredEffectStage
                    {
                        Id = Guid.Parse("0ee503cf-b4ce-4b33-9863-87bcb0c28a17"),
                        Duration = "1 day",
                        Effects =
                        {
                            new ConditionEffect { Id = Guid.Parse("fa1fa987-107c-4bbf-9d73-a34e01081a17"), ConditionId = Conditions.Instances.Drained.ID, Severity = 1}
                        }
                    },
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Chaotic.ID;
            yield return Traits.Instances.Disease.ID;
            yield return Traits.Instances.Evil.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a05d2269-8583-428d-927d-74d7b046204f"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 316
            };
        }
    }*/
}
