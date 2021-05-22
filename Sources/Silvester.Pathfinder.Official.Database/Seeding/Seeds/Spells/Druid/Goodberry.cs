using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class Goodberry : Template
    {
        public static readonly Guid ID = Guid.Parse("71c4ee4f-6eff-4d2c-91d8-ce47bee76a11");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Goodberry",
                Level = 1,
                Range = "Touch.",
                Duration = "10 minutes.",
                Targets = "1 ripe berry.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Druid.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65942fcb-79db-47ef-81c0-655bda22575b"), Type = TextBlockType.Text, Text = "You imbue the target berry with the bounty of nature. A creature can eat the berry with an Interact action to regain 1d6+4 HP. A berry not consumed during the duration withers away. Every six goodberries consumed gives as much nourishment as one square meal for a typical human." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2679239e-d161-4b79-8bdf-97346a0b575f"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("e30cf59d-35fc-4ad9-b398-88782b4b5e35"), Type = TextBlockType.Text, Text = "You can target an additional berry. A creature can consume any number of goodberries from the same casting with a single Interact action." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Druid.ID;
            yield return Traits.Instances.Healing.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c854bc66-9582-4bbf-9743-4c638fa9e4a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 399
            };
        }
    }
}
