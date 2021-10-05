using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Massacre : Template
    {
        public static readonly Guid ID = Guid.Parse("e51bf1f2-92f8-4c61-89c0-1350472a8bd5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Massacre",
                Level = 9,
                Area = "60-foot line.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90e2870d-a329-47cf-8d6d-8ecbbd7c72f5"), Type = TextBlockType.Text, Text = "You unleash a wave of necromantic energy to snuff out the life force of those in its path. Each living creature of 17th level or lower in the line must attempt a Fortitude save. If the damage from massacre reduces a creature to 0 Hit Points, that creature dies instantly. If massacre doesn’t kill even a single creature, the negative energy violently explodes back toward you, dealing an additional 30 negative damage to every living creature in the line (even those above 17th level) and 30 negative damage to you." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f9661664-ab6e-43b0-9b97-97b732d33c01"), 
                Level = "10th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ef53420b-d206-4f4f-b390-1558a179dc9c"), Type = TextBlockType.Text, Text = "The spell can affect living creatures up to 19th level. Increase the damage to 10d6 on a success, and to 115 on a failure." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("1adbe63b-021b-4ded-a2a9-2e089012f210"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes 9d6 negative damage.",
                Failure = "The creature takes 100 negative damage.",
                CriticalFailure = "The creature dies."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa2214eb-d4bc-4567-948b-5ae3513c40f5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 350
            };
        }
    }
}
