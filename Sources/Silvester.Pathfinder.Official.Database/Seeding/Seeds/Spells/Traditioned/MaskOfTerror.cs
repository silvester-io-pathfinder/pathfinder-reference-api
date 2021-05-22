using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MaskOfTerror : Template
    {
        public static readonly Guid ID = Guid.Parse("3710ee0e-bee7-42fa-8469-cce73389e447");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Mask of Terror",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f6ec0bfa-286f-44ef-9a59-00282f4d5657"), Type = TextBlockType.Text, Text = "The target appears to be a gruesome and terrifying creature. The effect is unique to each observer, so a human viewing the target might see a demon with bloody fangs, but a demon observing the target might see a glowing angelic visage." };
            yield return new TextBlock { Id = Guid.Parse("c591c946-6270-43dd-863d-818cebc532cf"), Type = TextBlockType.Text, Text = "When any creature attempts a hostile action against the target, the creature must attempt a Will save. It is then temporarily immune until the end of its next turn." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("baeb5ffd-1f4e-4fe2-86c2-3c3e2fec4274"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8f93f0b7-6aba-4a14-b278-afddfc8d51e1"), Type = TextBlockType.Text, Text = "You can target up to 5 creatures. If a creature uses a hostile action or reaction that affects multiple targets simultaneously, it needs to attempt only one save against mask of terror." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("789c5dfe-3724-43a4-8b0d-d8dd68dadf10"),
                Success = "The creature is unaffected.",
                Failure = "The creature becomes frightened 2 before using its action.",
                CriticalFailure = "The creature becomes frightened 2, and its action fails and is wasted."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Fear.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Visual.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3accc6ea-c273-43bc-8b92-233c4742f202"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 350
            };
        }
    }
}
