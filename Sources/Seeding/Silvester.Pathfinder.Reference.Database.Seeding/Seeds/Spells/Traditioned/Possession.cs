using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Possession : Template
    {
        public static readonly Guid ID = Guid.Parse("de5f1b30-7c64-4cb3-94d6-78a70ec916e5");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Possession",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 living creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34efb63b-9dd1-4f72-b620-e7bc8cae6cfd"), Type = TextBlockType.Text, Text = "You send your mind and soul into the target’s body, attempting to take control. The target must attempt a Will save. You can choose to use the effects of a degree of success more favorable to the target if you prefer." };
            yield return new TextBlock { Id = Guid.Parse("48814a28-dad7-4daa-b93e-b410e72d83d3"), Type = TextBlockType.Text, Text = "While you’re possessing a target, your own body is unconscious and can’t wake up normally. You can sense everything the possessed target does. You can Dismiss this spell. If the possessed body dies, the spell ends and you must succeed at a Fortitude save against your spell DC or be paralyzed for 1 hour, or 24 hours on a critical failure. If the spell ends during an encounter, you act just before the possessed creature’s initiative count." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("3ecaf0ff-4359-4b77-b691-cd2ff1a67fc0"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c4dd7176-03fe-4dfe-8cee-4d3d00bf2cac"), Type = TextBlockType.Text, Text = "The duration is 10 minutes, and you can physically enter the creature’s body, protecting your physical body while the spell lasts." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ffa77e27-aab6-4a06-9599-c9a1b8ab5920"),
                CriticalSuccess = "The target is unaffected.",
                Success = "You possess the target but can’t control it. You ride along in the body while the spell lasts.",
                Failure = "You possess the target and take partial control of it. You no longer have a separate turn; instead, you might control the target. At the start of each of the target’s turns, it attempts another Will save. If it fails, it’s controlled by you on that turn; if it succeeds, it chooses its own actions; and if it critically succeeds, it forces you out and the spell ends.",
                CriticalFailure = "You possess the target fully, and it can only watch as you manipulate it like a puppet. The target is controlled by you."
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Possession.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2741fa76-f0fd-4dc4-9cde-fdf803d32077"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 358
            };
        }
    }
}
