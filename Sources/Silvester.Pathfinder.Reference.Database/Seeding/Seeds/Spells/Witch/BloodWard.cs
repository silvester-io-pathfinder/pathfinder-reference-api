using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BloodWard : Template
    {
        public static readonly Guid ID = Guid.Parse("6e28a86d-191a-4d9c-92d1-9a7a62916f45");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blood Ward",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("623104e0-0621-4b0e-a0d3-a59375705e56"), Type = TextBlockType.Text, Text = "You consolidate warding energies with a gesture, guarding a creature against attacks from a certain type of foe. Designate one of the following creature traits: aberration, animal, beast, celestial, construct, dragon, elemental, fey, fiend, fungus, monitor, ooze, plant, or undead. The target gains a +1 status bonus to its saving throws and AC against creatures with that trait. The target is temporarily immune for 10 minutes." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d936dd3b-afc9-45d3-9b67-a78d28ef5e03"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("108a2bcd-23f7-4880-8351-8192ec9a2395"), Type = TextBlockType.Text, Text = "The status bonus increases to +2." }
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
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eab93d8f-3ce7-489f-938d-f035ab17dec9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 237
            };
        }
    }
}
