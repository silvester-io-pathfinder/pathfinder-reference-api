using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
                Success = "The creature takes 1 damage of the type of weakness you chose (thus triggering the creature's weakness), or loses its resistance until the end of your next turn if you chose a resistance.",
                Failure = "As success, and the creature becomes frightened 1 from the revelation of its dread secret.",
                CriticalFailure = "As failure, except the creature is frightened 3."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ab4ab921-7d4b-4779-a0c9-ed1e9eb94278"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b9b828af-8a85-4496-8520-e56827442286"), Traits.Instances.Cursebound.ID);
            builder.Add(Guid.Parse("46321ced-270b-4089-bdd1-7ae0b6370542"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("2d7e8e15-c583-4a87-8ab3-91f7044a2cb8"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("69c0eae1-e4db-4579-8d2d-1eeccca13d98"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("539d0526-e5a1-46a6-8fe7-95860c767f2b"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("d7cf217d-1776-4559-b2c5-33174f8df3dc"), Traits.Instances.Oracle.ID);
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
