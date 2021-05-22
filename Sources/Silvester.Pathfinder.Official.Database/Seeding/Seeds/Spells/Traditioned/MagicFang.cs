using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicFang : Template
    {
        public static readonly Guid ID = Guid.Parse("dcfd1a3e-e976-4943-b6d3-b7ea695f5ba7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Fang",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 willing creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("216e6d5a-d147-4982-83b2-6fd711da9a9a"), Type = TextBlockType.Text, Text = "Choose one of the target’s unarmed attacks. You cause that unarmed attack to shine with primal energy. The unarmed attack becomes a +1 striking unarmed attack, gaining a +1 item bonus to attack rolls and increasing the number of damage dice to two if it had only one." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("80f0377b-4bbc-43a5-85c0-1433d57eccd5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 349
            };
        }
    }
}
