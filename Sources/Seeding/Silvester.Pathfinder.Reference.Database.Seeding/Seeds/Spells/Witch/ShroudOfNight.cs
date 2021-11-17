using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ShroudOfNight : Template
    {
        public static readonly Guid ID = Guid.Parse("5bc3a789-1e57-4e0a-b1a2-c495e1fa3942");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shroud of Night",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6317af0-9b81-4a27-b565-7f4359d70ab7"), Type = TextBlockType.Text, Text = "Drawing your hand in a sweeping gesture, you shroud the target in a veil of night. The target’s eyes are blanketed in darkness. If you cast this hex on a willing ally (for instance, one with light blindness), the ally can choose which result it gets without rolling. Regardless of the outcome, the target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("a9cd0968-05e4-42d5-9f30-09abbdad067f"),
                Success = "The target is unaffected.",
                Failure = "The target is shrouded in murky darkness. Unless the target has darkvision, other creatures are concealed to it.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Darkness.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("122ab48e-954e-4ec3-8841-d292ba8ba655"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
