using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AirWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("5c0b6313-4951-4dc4-9289-0ec20210643d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Air Walk",
                Duration = "5 minutes.",
                Targets = "1 creature.",
                Range = "Touch.",
                Level = 4,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c32648f-499d-4392-aed9-194555267d3c"), Type = Utilities.Text.TextBlockType.Text, Text = "The target can walk on air as if it were solid ground. It can ascend and descend in this way at a maximum of a 45 - degree angle." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Air.ID;
            yield return Traits.Instances.Transmutation.ID;
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
