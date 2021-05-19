using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AlterReality : Template
    {
        public static readonly Guid ID = Guid.Parse("5cffbfee-9c91-4c00-a8e5-d24c75200deb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Alter Reality",
                Level = 10,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("56f45e68-032c-4929-a269-978e6d27a77c"), Type = Utilities.Text.TextBlockType.Text, Text = "You use your occult lore and the power of your mind to manipulate the spiritual multiverse" };
            yield return new TextBlock { Id = Guid.Parse("f2b10f10-1854-4e8b-b052-304b6fe58f9f"), Type = Utilities.Text.TextBlockType.Text, Text = "The spell has the following effects:" };
            yield return new TextBlock { Id = Guid.Parse("b56cb637-0b05-4b5e-a9c8-41d717987cf7"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Duplicate any occult spell of 9th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("18c4ba08-3dcf-4336-b349-bc3929058dc5"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Duplicate any non-occult spell of 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("dadf406b-366a-4ca6-8624-d4f315438b58"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Produce any effect whose power is equivalent to any occult spell 9th level or lower, or non - occult spell 7th level or lower." };
            yield return new TextBlock { Id = Guid.Parse("2e8f36e1-e005-43fd-9ed9-26b6e8710a44"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Reverse certain effects that refer to the wish spell" };
            yield return new TextBlock { Id = Guid.Parse("9b6100f0-8551-4d82-b8a8-c642e5e859cd"), Type = Utilities.Text.TextBlockType.Text, Text = "At the GM’s discretion, you can try to produce greater effects, but this is dangerous and the spell may have only a partial effect." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 317
            };
        }
    }
}
