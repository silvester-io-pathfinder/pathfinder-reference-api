using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HeartsDesire : Template
    {
        public static readonly Guid ID = Guid.Parse("12b35d4a-e05c-476d-a7d6-57a7beddeb28");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Heart's Desire",
                Level = 3,
                Range = "60 feet.",
                Targets = "1 creature.",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f76739b4-a175-4edf-b50f-e4a286ad8f2e"), Type = TextBlockType.Text, Text = "You surround your target with wondrous illusions of their greatest desires, which distract them from reality. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("156d291f-e675-41bb-a723-54d2c1e3358c"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("157d9b76-19ae-4fa7-bd73-4e167347bbf9"), Type = TextBlockType.Text, Text = "You can target one additional creature." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("81ea4c1f-1fa0-446f-9154-8f58665f5e10"),
                CriticalSuccess = "The target disbelieves the illusion and is unaffected.",
                Success = "For 1 round, the target is stupefied 2 and takes a –2 status penalty to any checks it makes to determine the effects of reactions.",
                Failure = "For 1 minute, the target is stupefied 2 and can’t use reactions.",
                CriticalFailure = "As failure, and all spaces are difficult terrain for the target."
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
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c324cc91-4b28-4087-955e-ab88ff554f42"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 236
            };
        }
    }
}
