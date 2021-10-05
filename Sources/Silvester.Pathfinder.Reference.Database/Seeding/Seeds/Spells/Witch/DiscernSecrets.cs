using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DiscernSecrets : Template
    {
        public static readonly Guid ID = Guid.Parse("21210ee4-3b48-4550-ac21-e3ba8f3408a9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Discern Secrets",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40b0aa62-eaab-42f7-8931-6feaa486d522"), Type = TextBlockType.Text, Text = "You call upon your patron’s power to better uncover secrets. When you Cast the Spell, the target can Recall Knowledge, Seek, or Sense Motive. The target gains a +1 status bonus to the skill or Perception used for the roll, and this bonus remains as long as you Sustain the Spell. The target is temporarily immune to discern secrets for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d9516077-60f0-4c23-b08a-8d35f2d23c63"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e04de109-bd2a-4c0f-afd1-44c8e57ad144"), Type = TextBlockType.Text, Text = "You can target two creatures instead of one." }
                }
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
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d875e1f6-e5fa-49a4-a090-ef850460e32e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
