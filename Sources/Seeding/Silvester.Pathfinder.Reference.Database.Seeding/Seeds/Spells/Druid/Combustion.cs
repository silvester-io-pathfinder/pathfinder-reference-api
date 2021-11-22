using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Combustion : Template
    {
        public static readonly Guid ID = Guid.Parse("51fb1636-7b04-4443-b4f4-3ff579c7731d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Combustion",
                Level = 3,
                Range = "120 feet.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0cfd5977-acfa-489f-954e-ce14facf2080"), Type = TextBlockType.Text, Text = "You ignite a creature in lasting flames. The fire deals 4d8 fire damage and 2d6 persistent fire damage to the creature, which must attempt a Fortitude save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8c20e553-8fe4-4857-9a47-0ac562683a9d"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("2047c8c6-4e31-4c72-a1b1-7f505ee60c2f"), Type = TextBlockType.Text, Text = "Increase the initial damage by 1d8 and the persistent damage by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4312e843-cb6b-42eb-941f-2393d05e799e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage and takes no persistent damage.",
                Failure = "The creature takes full damage, as well as full persistent damage.",
                CriticalFailure = "The creature takes double damage, as well as double persistent damage."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c23c7bf6-5a41-4618-9983-0339a7d6758a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 200
            };
        }
    }
}