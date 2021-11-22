using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WarpedTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("6246ae7b-b91f-4ae4-a70b-9604f0ecfc8c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warped Terrain",
                Level = 1,
                Range = "60 feet.",
                Area = "50foot burst or more.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25872de5-0044-4d23-b17d-b8ad20779569"), Type = TextBlockType.Text, Text = "You create illusory hazards that cover all surfaces in the area (typically the ground). Any creature moving through the illusion treats the squares as difficult terrain. A creature can attempt to disbelieve the effect as normal after using a Seek action or otherwise spending actions interacting with the illusion. If it successfully disbelieves, it ignores the effect for the remaining duration. For each additional action you use casting the spell, the burst's radius increases by 5 feet, to a maximum of 10 extra feet for 3 actions." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cceb24a7-f6ca-48ea-bc7a-7a2fd8b20d0a"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("f3baa1f0-a25c-4d51-8084-32e265e3e08c"), Type = TextBlockType.Text, Text = "You can make the illusion appear in the air rather than on a surface, causing it to function as difficult terrain for flying creatures." }
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
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ef0456b3-0fe5-496e-8d9f-8da9272fc934"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
