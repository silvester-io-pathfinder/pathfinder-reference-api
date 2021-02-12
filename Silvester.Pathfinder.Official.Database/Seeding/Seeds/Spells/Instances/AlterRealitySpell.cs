using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AlterRealitySpell : AbstractSpellTemplate
    {
        public override string SpellType => "Spell";
        public override string ActionType => "Three Actions";
        public override string MagicSchool => "Abjuration";

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = Guid.Parse("5cffbfee-9c91-4c00-a8e5-d24c75200deb"),
                Name = "Alter Reality",
                Description = "You use your occult lore and the power of your mind to manipulate the spiritual multiverse",
                Level = 10
            };
        }

        public override IEnumerable<SpellDetailBlock> GetSpellDetailBlocks()
        {
            yield return new SpellDetailBlock { Id = Guid.Parse("f2b10f10-1854-4e8b-b052-304b6fe58f9f"), Text = "The spell has the following effects:" };
            yield return new SpellDetailBlock { Id = Guid.Parse("b56cb637-0b05-4b5e-a9c8-41d717987cf7"), Text = "- Duplicate any occult spell of 9th level or lower." };
            yield return new SpellDetailBlock { Id = Guid.Parse("18c4ba08-3dcf-4336-b349-bc3929058dc5"), Text = "- Duplicate any non-occult spell of 7th level or lower." };
            yield return new SpellDetailBlock { Id = Guid.Parse("dadf406b-366a-4ca6-8624-d4f315438b58"), Text = "- Produce any effect whose power is equivalent to any occult spell 9th level or lower, or non - occult spell 7th level or lower." };
            yield return new SpellDetailBlock { Id = Guid.Parse("2e8f36e1-e005-43fd-9ed9-26b6e8710a44"), Text = "- Reverse certain effects that refer to the wish spell" };
            yield return new SpellDetailBlock { Id = Guid.Parse("9b6100f0-8551-4d82-b8a8-c642e5e859cd"), Text = "At the GM’s discretion, you can try to produce greater effects, but this is dangerous and the spell may have only a partial effect." };
        }

        public override IEnumerable<string> GetSpellComponents()
        {
            yield return "Material";
            yield return "Somatic";
            yield return "Verbal";
        }

        public override IEnumerable<string> GetMagicTraditions()
        {
            yield return "Occult";
        }

        public override IEnumerable<string> GetTraits()
        {
            yield return "Divination";
        }
    }
}
