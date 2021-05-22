using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class MeldIntoStone : Template
    {
        public static readonly Guid ID = Guid.Parse("673fb99e-1fa7-40e7-b9e5-23bccf075cef");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Meld Into Stone",
                Level = 3,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("54e609fa-82d3-4e0c-a712-be22fc1ecbde"), Type = TextBlockType.Text, Text = "You merge with an adjacent block of stone with enough volume to fit you and your worn and held possessions. You must touch the stone when you Cast the Spell. You can hear, but not see, what’s going on outside the stone, and you can cast spells while in the stone as long as they don’t require line of effect beyond the stone." };
            yield return new TextBlock { Id = Guid.Parse("a13e2fdb-9934-44a3-b316-2be6b08dca4d"), Type = TextBlockType.Text, Text = "Significant physical damage to the stone while you are inside it expels you and deals 10d6 damage to you. Passwall expels you without dealing damage and ends meld into stone. You can Dismiss this spell." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Earth.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f35ab2a-a72b-4ed1-9d29-17f24931c27a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 350
            };
        }
    }
}
