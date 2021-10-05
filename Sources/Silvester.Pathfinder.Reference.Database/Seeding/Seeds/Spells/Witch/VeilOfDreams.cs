using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class VeilOfDreams : Template
    {
        public static readonly Guid ID = Guid.Parse("4563a251-40f7-4063-8615-9ad2f3fa79b9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Veil of Dreams",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("460a27e2-c4e7-4ebc-8e65-0907c279f9f7"), Type = TextBlockType.Text, Text = "You draw the target into a drowsy state, causing daydreams and sluggishness. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("89c97ffd-580b-42c2-8bba-7d76162dc651"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target takes a –1 status penalty to Perception, attack rolls, and Will saves. This penalty increases to –2 for Will saves against sleep effects.",
                Failure = "As success, and any time the target uses a concentrate action, it must succeed at a DC 5 flat check or the action is disrupted.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0719eb4e-772c-4479-b06f-9ddc4cb564dc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
