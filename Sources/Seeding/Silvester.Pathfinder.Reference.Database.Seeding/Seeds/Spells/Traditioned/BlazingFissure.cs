using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlazingFissure : Template
    {
        public static readonly Guid ID = Guid.Parse("63a212fb-a2aa-42db-95b7-1a5aab132f73");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blazing Fissure",
                Level = 5,
                Area = "120-foot line.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a17a155e-810a-40a4-b2c3-39f81b4b0ea5"), Type = TextBlockType.Text, Text = "A thin crack rips through the earth, erupting with magma, then swiftly seals up. Each creature along the line and on solid ground takes 4d6 bludgeoning damage and 6d6 fire damage with a Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6c947137-efec-4eed-99df-d4851f0ba047"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("e2ef03c5-e472-4036-b7cb-246fe61f3ff7"), Type = TextBlockType.Text, Text = "The damage increases by 1d6 bludgeoning and 1d6 fire." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1d79628e-83fc-4fd6-80b7-0f1ed0dfb018"),
                CriticalSuccess = "The creature is unaffected",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage, and it falls prone.",
                CriticalFailure = "The target takes double damage, and it falls prone."
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
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5489292-d48d-40d0-acd1-291b7572ee0d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 91
            };
        }
    }
}
