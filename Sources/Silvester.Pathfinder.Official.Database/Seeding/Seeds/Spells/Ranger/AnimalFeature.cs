using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimalFeature : Template
    {
        public static readonly Guid ID = Guid.Parse("49f819b2-863c-4072-b031-18b8c8d0d214");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animal Feature",
                Level = 2,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38d4480b-e74a-4cb9-9ded-e9514eff230e"), Type = TextBlockType.Text, Text = "Without fully transforming your body, you gain one animalistic feature, which you select from the list below each time you Cast the Spell." };
            yield return new TextBlock { Id = Guid.Parse("37fa1355-33f1-4d97-bf7a-513a1437fb93"), Type = TextBlockType.Enumeration, Text = "Cat Eyes - You gain low-light vision." };
            yield return new TextBlock { Id = Guid.Parse("ae1e30db-aec5-4126-a111-41adfe69ccaf"), Type = TextBlockType.Enumeration, Text = "Claws - You gain a claw attack that deals 1d6 slashing damage and has the agile, finesse, and unarmed traits." };
            yield return new TextBlock { Id = Guid.Parse("4e3a0bc1-4a55-40c1-91e5-ad57f850f011"), Type = TextBlockType.Enumeration, Text = "Jaws - You gain a jaws attack that deals 1d8 piercing damage and has the unarmed trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6b2f2858-937c-4cf9-96a2-c8ceee0cd0a1"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("12a02b72-4a6e-4600-86a0-d851a2b3da02"), Type = TextBlockType.Text, Text = "Add the following options to the list you can choose from:" },
                    new TextBlock { Id = Guid.Parse("8cf9d481-45d0-4875-b3ec-6c39e36f6886"), Type = TextBlockType.Enumeration, Text = "Fish Tail - You gain a swim Speed equal to your land Speed." },
                    new TextBlock { Id = Guid.Parse("ae1a6c65-13a8-4280-99e6-7648a2541ba1"), Type = TextBlockType.Enumeration, Text = "Owl Eyes - You gain darkvision." },
                    new TextBlock { Id = Guid.Parse("0ba6646b-e28a-4f37-88d9-1a1f8dad1646"), Type = TextBlockType.Enumeration, Text = "Wings - You gain a fly Speed equal to your land Speed." },
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
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Ranger.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("546efa4f-a6e1-4601-9a3b-51edd0ef9038"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 234
            };
        }
    }
}
