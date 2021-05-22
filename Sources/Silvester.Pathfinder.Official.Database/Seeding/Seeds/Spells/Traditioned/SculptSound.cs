using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SculptSound : Template
    {
        public static readonly Guid ID = Guid.Parse("5921d0aa-6dd2-4dae-bb5e-ee4bf98bda81");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "SculptSound",
                Level = 3,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "10 minutes.",
                Targets = "1 creature or object.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("95d259d2-46db-43d6-a19f-4888000eab22"), Type = TextBlockType.Text, Text = "You change the sounds made by a creature or object. Choose how you’re altering the sounds when you Cast the Spell; you can’t alter it later. You can cause something that didn’t create a sound to make sound, alter the voice of a creature, amplify or deaden a sound, or transform one sound into another. A creature who succeeds at a Perception check against your spell DC can determine that the sound was altered by an illusion, including hearing faint sounds if you deadened the sound, but they can’t determine the true sound unless they critically succeed at the Perception check. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("05de2699-f509-4cfd-97df-9e2cb1bead6e"), Type = TextBlockType.Text, Text = "Because this spell obscures sound instead of preventing it, using the spell to quiet a creature doesn’t prevent that creature from using verbal spell components, though it does prevent most auditory effects that rely on another creature hearing them accurately. An unwilling target can attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("0be69a44-1a91-4580-b756-0d5d3fe2968a"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e226f61a-b1b0-4211-a671-d54fc30e8cb0"), Type = TextBlockType.Text, Text = "You can target up to 6 creatures or 6 objects, altering the sounds of all affected creatures or objects in the same way." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("4ed5faae-d4f7-4835-b64e-ef4fdd708b6b"),
                Success = "The affected sound from the creature isn’t altered.",
                Failure = "The affected sound from the creature is altered in the way you determine.",
                CriticalFailure = "The affected sound from the creature is altered and the target becomes stupefied 2 for 1 minute as it struggles with the disorienting effects of its altered sound."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Illusion.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d18eac95-d8a9-4ae5-ad49-4c4562990c64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 224
            };
        }
    }
}
