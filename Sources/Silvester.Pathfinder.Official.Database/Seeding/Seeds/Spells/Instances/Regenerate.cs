using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Regenerate : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Regenerate",
                Level = 7,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing living creature.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An infusion of positive energy grants a creature continuous healing. The target temporarily gains regeneration 15, which restores 15 Hit Points to it at the start of each of its turns. While it has regeneration, the target can’t die from damage and its dying condition can’t increase to a value that would kill it (this stops most creatures from going beyond dying 3), though if its wounded value becomes 4 or higher, it stays unconscious until its wounds are treated. If the target takes acid or fire damage, its regeneration deactivates until after the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time the creature regains Hit Points from regeneration, it also regrows one damaged or ruined organ (if any). During the spell’s duration, the creature can also reattach severed body parts by spending an Interact action to hold the body part to the area it was severed from." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The regeneration increases to 20." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Positive.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 363
            };
        }
    }
}
