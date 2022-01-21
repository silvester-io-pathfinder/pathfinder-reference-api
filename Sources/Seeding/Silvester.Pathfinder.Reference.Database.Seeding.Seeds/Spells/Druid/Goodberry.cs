using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7227b867-a201-424a-adf9-94190836899e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("eb9b06e9-a1d0-48b9-8eac-867c2c0b5e61"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("eb926184-d65a-43c0-bd47-1495d842c2ef"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("c3a015cb-2120-4f34-89f9-fd5c3ed710f7"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("9ad68df7-9052-4970-91fc-7328e681cd7f"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("62f38e0e-8958-4bd0-b659-a265cca738eb"), Traits.Instances.Evocation.ID);
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
