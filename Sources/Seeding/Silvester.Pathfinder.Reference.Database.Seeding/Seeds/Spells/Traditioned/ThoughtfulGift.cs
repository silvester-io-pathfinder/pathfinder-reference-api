using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ThoughtfulGift : Template
    {
        public static readonly Guid ID = Guid.Parse("acf134b9-edf8-49e8-bb1a-b57668cb8504");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Thoughtful Gift",
                Level = 1,
                Range = "120 feet.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13e49035-8698-43ed-a8a2-d73e6193048e"), Type = TextBlockType.Text, Text = "You teleport one object of light or negligible Bulk held in your hand to the target. The object appears instantly in the target's hand, if they have a free hand, or at their feet if they don't. The target knows what object you are attempting to send them. If the target is unconscious or refuses to accept your gift, or if the spell would teleport a creature (even if the creature is inside an extradimensional container), the spell fails." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a8686ce8-055b-403c-947e-83c8fc071342"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7c79a7d6-8900-4390-8e26-a2f2f81c335d"), Type = TextBlockType.Text, Text = "The spell's range increases to 500 feet." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("8c1d108b-66d2-4078-b00d-c828d6036ebe"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("af6b1420-7885-462e-a50f-76c41f6067a5"), Type = TextBlockType.Text, Text = "As 3rd level, and the object's maximum Bulk increases to 1. You can Cast the Spell with 3 actions instead of 1; doing so increases the range to 1 mile and you don't need line of sight to the target, but you must be extremely familiar with the target." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5867339-c24a-468f-9ee3-cf15c7489e6a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 226
            };
        }
    }
}
