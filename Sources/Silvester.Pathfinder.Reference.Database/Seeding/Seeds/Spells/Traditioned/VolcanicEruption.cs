using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VolcanicEruption : Template
    {
        public static readonly Guid ID = Guid.Parse("120f7798-342f-42f8-a213-8053fbc4f6bf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Volcanic Eruption",
                Level = 7,
                Range = "120 feet.",
                Area = "5-foot radius, 80-foot-tall cylinder.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3bd83d19-4071-43d5-a369-9e0970685e7b"), Type = TextBlockType.Text, Text = "The ground opens up, spraying a column of lava high into the air in a vertical cylinder, dealing 14d6 fire damage to creatures in the area. The lava rapidly cools and encases creatures in the area. A creature encased in rock is clumsy 1 and takes a –10-foot status penalty to its Speeds. All normal terrain is difficult terrain to a flying creature, and such creatures immediately descend 20 feet the moment they’re encased, but they don’t take damage from this fall. A creature encased in rock can attempt to Escape against your spell DC to end the effect. Otherwise, the creature remains encased until it takes a total of 50 damage, freeing it from the rock." };
            yield return new TextBlock { Id = Guid.Parse("308a052a-de86-425c-84ab-8972fe579ae6"), Type = TextBlockType.Text, Text = "Additionally, creatures in the area and those within 5 feet of the lava column automatically take 3d6 fire damage from the intense heat, regardless of the results of their saving throws." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b0dd0ba5-cf48-43ae-9ccc-059047c9ee4b"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2099bdf1-de40-4870-b493-53852d8a3b56"), Type = TextBlockType.Text, Text = "The damage in the area increases by 2d6, and the damage from the intense heat increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("344ce0bd-a1f3-4082-8199-7213834d216e"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes half damage.",
                Failure = "The creature takes full damage and is encased.",
                CriticalFailure = "The creature takes double damage and is encased."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e01b3c21-3177-4d8c-a88a-d466914c9eb3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
