using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class NudgeFate : Template
    {
        public static readonly Guid ID = Guid.Parse("f0c0a047-e37b-4380-b823-1fe3d7e7cdba");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nudge Fate",
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
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f0c0a047-e37b-4380-b823-1fe3d7e7cdba"), Type = TextBlockType.Text, Text = "You read slightly into the future and give fate a tiny push to achieve the result you desire. Once during the duration, when the target fails an attack roll, skill check, or saving throw and a +1 status bonus would turn a critical failure into a failure, or failure into a success, you grant the target a +1 status bonus to the check retroactively, changing the outcome appropriately. The spell then ends, and the target is temporarily immune for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("f0c0a047-e37b-4380-b823-1fe3d7e7cdba"), Type = TextBlockType.Text, Text = "If you cast nudge fate while a previous casting of this hex is still in effect, the previous effect ends." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0c0a047-e37b-4380-b823-1fe3d7e7cdba"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
