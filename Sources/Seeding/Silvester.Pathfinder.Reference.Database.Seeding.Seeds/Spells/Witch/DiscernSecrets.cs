using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
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
            yield return new TextBlock { Id = Guid.Parse("40b0aa62-eaab-42f7-8931-6feaa486d522"), Type = TextBlockType.Text, Text = "You call upon your patron's power to better uncover secrets. When you Cast the Spell, the target can Recall Knowledge, Seek, or Sense Motive. The target gains a +1 status bonus to the skill or Perception used for the roll, and this bonus remains as long as you Sustain the Spell. The target is temporarily immune to discern secrets for 1 minute." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0dcd291b-e060-43ab-abb7-95023b22a3de"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("b4585781-3e49-45d2-baa0-72361afad4c0"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("a56519f0-a85b-4c1a-acf5-1e0d09777119"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("5278d4d0-a9a3-4e7b-8289-d9ab7881655c"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("894390e5-c685-4db7-a5bd-d90e64cd7546"), Traits.Instances.Witch.ID);
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
