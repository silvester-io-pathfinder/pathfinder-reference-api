using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DreadSecret : Template
    {
        public static readonly Guid ID = Guid.Parse("1ff088f8-98f6-4a8e-b15d-bedfe91cb20c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dread Secret",
                Level = 6,
                Range = "60 feet.",
                Targets = "Up to 6 creatures.",
                Duration = "Until the start of your next turn.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0e70b211-e1b8-4a23-aeab-3a43ba818ebb"), Type = TextBlockType.Text, Text = "You utter a powerful secret at odds with the fundamental nature of the target creatures. Choose a specific resistance or weakness that you believe one or more of the targets have due to Recall Knowledge or previous experience with the targets, such as resistance to fire or weakness to silver. If the information is incorrect for a given target, the spell has no effect on that target. Affected targets must attempt a Will saving throw." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("ecfdb38b-83db-4a76-abaf-223a38c2c202"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature takes 1 damage of the type of weakness you chose (thus triggering the creature’s weakness), or loses its resistance until the end of your next turn if you chose a resistance.",
                Failure = "As success, and the creature becomes frightened 1 from the revelation of its dread secret.",
                CriticalFailure = "As failure, except the creature is frightened 3."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Oracle.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fa0721b0-1077-49ce-8f80-bd25141dd4ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 231
            };
        }
    }
}
