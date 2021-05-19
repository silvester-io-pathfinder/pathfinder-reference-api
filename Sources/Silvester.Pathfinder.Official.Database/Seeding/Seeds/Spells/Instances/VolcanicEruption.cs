using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class VolcanicEruption : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The ground opens up, spraying a column of lava high into the air in a vertical cylinder, dealing 14d6 fire damage to creatures in the area. The lava rapidly cools and encases creatures in the area. A creature encased in rock is clumsy 1 and takes a –10-foot status penalty to its Speeds. All normal terrain is difficult terrain to a flying creature, and such creatures immediately descend 20 feet the moment they’re encased, but they don’t take damage from this fall. A creature encased in rock can attempt to Escape against your spell DC to end the effect. Otherwise, the creature remains encased until it takes a total of 50 damage, freeing it from the rock." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Additionally, creatures in the area and those within 5 feet of the lava column automatically take 3d6 fire damage from the intense heat, regardless of the results of their saving throws." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The damage in the area increases by 2d6, and the damage from the intense heat increases by 1d6." }
                }
            };
        }

        public override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse(""),
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 382
            };
        }
    }
}
