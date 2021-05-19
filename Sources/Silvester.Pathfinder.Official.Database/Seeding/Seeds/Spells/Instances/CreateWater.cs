using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CreateWater : Template
    {
        public static readonly Guid ID = Guid.Parse("c5bd7524-e3f5-46b6-b1de-527896978d1c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Create Water",
                Level = 1,
                Range = "0 feet.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3197459e-c6bc-431b-9a5e-45973bd75f1b"), Type = Utilities.Text.TextBlockType.Text, Text = "As you cup your hands, water begins to flow forth from them. You create 2 gallons of water. If no one drinks it, it evaporates after 1 day." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
