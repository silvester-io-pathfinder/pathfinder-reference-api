using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class VeilOfDreams : Template
    {
        public static readonly Guid ID = Guid.Parse("f329b0cc-16dd-4820-a5cc-4bcac9b94ba1");

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
            yield return new TextBlock { Id = Guid.Parse("f329b0cc-16dd-4820-a5cc-4bcac9b94ba1"), Type = TextBlockType.Text, Text = "You draw the target into a drowsy state, causing daydreams and sluggishness. The target must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("f329b0cc-16dd-4820-a5cc-4bcac9b94ba1"),
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
                Id = Guid.Parse("f329b0cc-16dd-4820-a5cc-4bcac9b94ba1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 239
            };
        }
    }
}
